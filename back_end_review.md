# IMuDB Back-End Code Review

> Reviewed: April 2026
> Scope: IMuDB.API, IMuDB.Domain, IMuDB.Infrastructure, IMuDB.Infrastructure.Extensions, IMuDB.Infrastructure.Services
> Focus: Architecture, .NET patterns, REST API best practices, and learning gaps

---

## What Is Working Well

### Layered Architecture

The project is structured across five distinct layers, each with a clear responsibility:

| Project                           | Role                                                       |
| --------------------------------- | ---------------------------------------------------------- |
| `IMuDB.Domain`                    | Entities, interfaces, DTOs, exceptions — the core contract |
| `IMuDB.Infrastructure`            | Data access — DbContext, repositories, migrations          |
| `IMuDB.Infrastructure.Extensions` | Mapping from entity → DTO                                  |
| `IMuDB.Infrastructure.Services`   | Business logic / orchestration                             |
| `IMuDB.API`                       | HTTP layer — controllers, filters, startup                 |

This is a solid approximation of Clean Architecture. `IMuDB.Domain` has no dependencies on anything else, which is exactly correct — the domain is the center of gravity and nothing outside it should dictate its shape.

### Repository Pattern with Generic Base

`GenericRepository<TEntity>` provides the CRUD foundation and specific repositories (e.g., `ActRepository`) extend it to add query-specific behavior like eager loading. The separation is clean and the pattern is widely recognized in .NET.

### Dependency Injection Done Right

Extension methods like `AddServices()` and `AddDataContext()` keep `Program.cs` thin and organize registrations logically. All dependencies are injected through constructors — this is exactly the right approach.

### DTO Separation

Request and response types are distinct from entity types. This is important: it lets you evolve your database schema independently from your API contract. The use of `{ get; init; }` on response DTOs (immutable after construction) is a thoughtful choice.

### Extension Methods for Mapping

Choosing explicit static extension methods over a library like AutoMapper is a valid and transparent approach. Every mapping is traceable — there is no magic, just code you can step through in a debugger.

### Soft Deletes via `IsActive`

Rather than permanently destroying records, setting `IsActive = false` preserves data history. This is a mature design decision with real-world value for auditing and recovery. The `GenericRepository.GetAllAsync()` base method now enforces `.Where(e => e.IsActive)`, and named repository methods apply the same filter — the pattern is consistent throughout the data access layer.

### `AsNoTracking()` on Read Queries

Read-only queries that call `.AsNoTracking()` avoid EF Core's change-tracking overhead. This is a meaningful performance optimization and shows awareness of how EF Core works under the hood.

### `ProducesResponseType` Attributes

Controllers document their expected response shapes and status codes. This populates Swagger correctly and communicates intent clearly to consumers of the API.

### Custom Domain Exception

`MissingSongsException` in `IMuDB.Domain.Exceptions` is a good start — it shows awareness that generic exceptions lose meaning and that domain-specific error types communicate intent better.

### Modern C# Features

Primary constructors, collection expressions (`return []`), null-coalescing throw expressions (`?? throw new Exception(...)`), and explicit variable types throughout all show engagement with modern C# syntax.

### `ICollection<T>` Navigation Properties

Navigation properties in entities correctly use `ICollection<T>` rather than `IEnumerable<T>`, enabling EF Core change tracking to function properly.

### Logging in Controllers

`ILogger<T>` is injected into all controllers via the primary constructor. Every `catch` block calls `logger.LogError()` with a structured format string.

### Validation Filters Fixed and Cleaned Up

The `ActUpdateRequestIdValidationFilterAttribute` and `AlbumUpdateRequestIdValidationFilterAttribute` now correctly cast the body argument to its DTO type (`ActUpdateRequest`, `AlbumUpdateRequest`) and read the `Id` property directly. The old `as string` cast that always produced `null` has been removed. The files have also been renamed to match the `Attribute` suffix convention.

### Soft Delete Filter in `GenericRepository`

`GetAllAsync()` now applies `.Where(e => e.IsActive)` before returning, ensuring soft-deleted records are excluded from all queries that go through the base method — regardless of which repository or service calls it.

---

## Areas to Investigate and Improve

### 1. Exception Handling and HTTP Status Codes

**Progress made:** `ILogger<T>` is in all controllers and `ActController.GetActByIdAsync` correctly returns `NotFound()` when the service returns null.

**Still open:** Every `catch` block across all controllers still returns `BadRequest(ex.Message)` — a database failure, a missing record, and a malformed request all produce the same 400 response. Additionally, `AlbumController.GetAlbumByIdAsync` and `SongController.GetSongByIdAsync` have no null-check after the service call and will return `Ok(null)` when the record doesn't exist, rather than `NotFound()`.

A few questions worth sitting with:

- Is every possible error actually a "bad request" (400)? What should happen when a record simply isn't found?
- What happens when the database goes down? Is that also a 400?
- `ex.Message` is being returned directly to the client. What might that message reveal about your internal implementation?

The HTTP status code vocabulary exists to give clients structured meaning. `404 Not Found`, `409 Conflict`, `422 Unprocessable Entity`, and `500 Internal Server Error` all carry different semantics that a well-behaved client depends on. Consider how a global exception handling middleware (e.g., `app.UseExceptionHandler`) might centralize this concern rather than repeating `try/catch` in every action.

---

### 2. Exception Throwing vs. Returning Results

Business logic that cannot complete a request still throws the base `Exception` type:

```csharp
throw new Exception($"Act with Id:{actId} could not be found");
throw new Exception($"Album with {createAlbumRequest.Name} by artist {createAlbumRequest.ActId} already exists");
```

Using the base `Exception` type loses the semantic distinction between "I couldn't find this" and "something unexpected happened." Consider: if you want the controller to respond with a `404`, how would it know that this particular exception means "not found" versus a database failure? How might a custom `NotFoundException` (similar to `MissingSongsException`) enable smarter HTTP mapping?

---

### 3. `CreatedAtRoute` Still Broken in `ActController`

<!-- **Progress made:** `AlbumController` is fully correct — `GetAlbumByIdAsync` has `Name = "GetAlbumByIdAsync"` on its `[HttpGet]` attribute, and `CreateAlbumAsync` references it with `nameof(GetAlbumByIdAsync)`. `ActController.GetActByIdAsync` also now has `Name = "GetActByIdAsync"`.

**Still open:** `ActController.CreateActAsync` still references a local variable name instead of the route name:

```csharp
return CreatedAtRoute(nameof(createdAct), new { id = createdAct.Id?.ToString() }, createdAct);
```

`nameof(createdAct)` resolves to the string `"createdAct"` — a local variable name. The route name `"GetActByIdAsync"` exists on the GET endpoint, but this call doesn't reference it. The fix is one word: `nameof(GetActByIdAsync)`. -->

---

### 4. Primary Constructor Parameter Naming Convention in Services

<!-- Controllers now use correctly-named parameters without the underscore prefix. Service classes retain the incorrect convention:

```csharp
public class ActService(IActRepository _actRepository, IMusicianRepository _musicianRepository)
public class AlbumServices(IAlbumRepository _albumRepository, IActRepository _actRepository, ...)
public class InstrumentService(IInstrumentRepository _instrumentRepository)
public class MusicianServices(IMusicianRepository _musicianRepository)
```

Primary constructor parameters are not fields — they are parameters. Prefixing them with `_` implies they are private backing fields, which they are not. Conventional naming uses camelCase without the prefix: `actRepository`, `musicianRepository`. -->

---

### 5. No Pagination on Collection Endpoints

`GetActsAsync`, `GetAlbumsAsync`, and `GetMusiciansAsync` all return the entire table. This is fine during development but will not scale. Returning 10,000 albums in a single response is a concern both for API performance and client usability. What would an API contract look like that supports pages? How might EF Core's `.Skip()` and `.Take()` be used here?

---

### 6. `GetAllActsAsync` Missing `AsNoTracking()`

<!-- The recent update to `ActRepository.GetAllActsAsync` removed the `.AsNoTracking()` call that was previously present:

```csharp
// Current — change tracking is active for this read-only query
return await _context.Acts
    .Include(act => act.Albums)
    .Where(act => act.IsActive)
    .ToListAsync();
```

`GetActByIdAsync` still correctly applies `.AsNoTracking()`. For a read-only list query that feeds a DTO mapping, change tracking provides no benefit and adds memory overhead. This appears to be an accidental omission from the refactor. -->

---

## Learning Focus Areas

### Immediate Priority

- **HTTP semantics** — Read RFC 7231 or any good summary of what each 4xx and 5xx code means and when to use it. Understanding this is foundational to building APIs that other developers can integrate against confidently.
- **Global exception middleware** — Research `app.UseExceptionHandler` and `IExceptionHandler` (ASP.NET Core 8+). Centralized error handling eliminates the try/catch boilerplate in every controller.
- **Fix `CreatedAtRoute` in `ActController`** — One-word change: `nameof(createdAct)` → `nameof(GetActByIdAsync)`.
- **Add null-checks in `AlbumController` and `SongController`** — `GetAlbumByIdAsync` and `GetSongByIdAsync` should return `NotFound()` when the service returns null, matching the pattern already used in `ActController`.

### Medium Priority

- **Structured logging with `ILogger<T>`** — Logging is now in controllers. The next step is understanding log levels (`Debug`, `Information`, `Warning`, `Error`) and why structured logs (e.g., `_logger.LogError(ex, "Failed to find act {ActId}", actId)`) are more useful than string-concatenated messages. Consider adding `ILogger<T>` to services as well.
- **Input validation** — Research `DataAnnotations` (`[Required]`, `[StringLength]`, `[Range]`) on DTO properties and how `[ApiController]` automatically returns 400 on model state failures. Then look at **FluentValidation** as a more powerful alternative.
- **Result pattern** — Look at returning `Result<T>` or `OneOf<T, Error>` from services instead of throwing exceptions for expected failure cases. This is a popular pattern in modern .NET that removes ambiguity about what "throwing" means in a service.

### Longer Term

- **Authentication and Authorization** — `app.UseAuthorization()` is wired in but unused. JWT bearer tokens and the `[Authorize]` attribute are the next meaningful capability to add to this API.
- **Pagination and filtering** — Research the `OData` or cursor-based pagination patterns. Consider what a paginated `GET /api/acts?page=1&pageSize=20` endpoint looks like end-to-end.
- **Unit testing services** — The layered architecture you have is well-suited to unit testing. Services can be tested with mocked repositories (using `Moq` or `NSubstitute`) without needing a real database.
- **CQRS (Command Query Responsibility Segregation)** — As the application grows, separating read models from write models becomes valuable. The current service pattern is one step away from this — understanding CQRS will help you see where the current approach naturally leads.

---

## SOLID Principles Assessment

SOLID is a set of five design principles intended to make object-oriented code more maintainable and extensible. Here is how the codebase currently measures up against each one.

---

### S — Single Responsibility Principle

> _A class should have only one reason to change._

**Where it holds:**
Controllers are genuinely thin — they handle HTTP concerns only and immediately delegate to services. Repositories focus on data access. This is correct.

**Where it breaks down:**

The service methods do too much in a single place. `CreateActAsync` validates the request, fetches related musicians from the database, constructs new `MusicianEntity` and `ActEntity` objects inline, and then persists everything — four distinct concerns inside one method. If the entity construction rules change, the service changes. If the persistence strategy changes, the service changes. That is two reasons to change in one method.

The same pattern repeats in `CreateAlbumAsync`. Consider: should the knowledge of _how to build a_ `MusicianEntity` live inside a service, or somewhere else?

`DataContextRegistration.cs` is responsible for both configuring the `DbContext` and registering all repositories. Two responsibilities in one class — if you reorganize repositories into different assemblies, this class needs to change for two unrelated reasons.

---

### O — Open/Closed Principle

> _Classes should be open for extension but closed for modification._

**Where it holds:**
`GenericRepository<TEntity>` is a textbook application of OCP — `ActRepository` extends it by inheriting and adding methods, without touching the base. `BaseEntity` follows the same idea for entities. This is the right pattern.

**Where it breaks down:**

Every new entity you add to the system requires modifying `ServiceRegistration.cs` and `DataContextRegistration.cs` to register the new service and repository. Those classes are never "closed" — they grow forever. Look at what ASP.NET Core's own conventions do: `AddControllers()` discovers all controllers without anyone listing them manually. Could the same principle apply here?

The two update validation filters (`ActUpdateRequestIdValidationFilterAttribute`, `AlbumUpdateRequestIdValidationFilterAttribute`) are structurally identical. They differ only in the DTO type and argument key string. Adding a third entity means copying a third class. There is no extension point — the class itself must be duplicated. This is the opposite of open for extension.

---

### L — Liskov Substitution Principle

> _Subtypes must be substitutable for their base types without breaking the program._

**Where it holds:**
`ActRepository` inherits `GenericRepository<ActEntity>` and adds methods without overriding or weakening the behavior of the base. You could use either type interchangeably where only the base contract is needed. This is correct.

**Where it breaks down:**

The `= null!` suppressor on required navigation properties (e.g., `Musicians`) tells the compiler "trust me, this won't be null," but at runtime it can be, which means callers treating the property as safely non-null could get `NullReferenceException`. The type says one thing; the runtime can do another.

---

### I — Interface Segregation Principle

> _Clients should not be forced to depend on methods they do not use._

**Where it holds:**
The individual service interfaces (`IActService`, `IAlbumService`, etc.) are specific rather than monolithic. Controllers only depend on the interface they need. This is good.

**Where it breaks down:**

`IGenericRepository<TEntity>` bundles GetAll, GetById, Add, Update, and Delete into one interface. Consider a hypothetical read-only audit log repository — it would be forced to implement `AddEntityAsync`, `UpdateEntityAsync`, and `DeleteByIdAsync` even though it should never write. Should read concerns and write concerns be the same interface?

---

### D — Dependency Inversion Principle

> _High-level modules should not depend on low-level modules. Both should depend on abstractions._

**Where it holds:**
Controllers depend on service interfaces. Services depend on repository interfaces. Neither layer depends on a concrete implementation. DI is configured in the composition root (`Program.cs`). This is the correct application of DIP throughout.

**Where it breaks down:**

Inside the services, entities are constructed inline:

```csharp
new MusicianEntity
{
    Id = Guid.NewGuid().ToString(),
    IsActive = true,
    CreatedAt = DateTime.UtcNow,
    UpdatedAt = DateTime.UtcNow
}
```

This pattern appears identically in `CreateActAsync`, `UpdateActAsync`, and `CreateAlbumAsync`. The service is making decisions that belong to a lower-level concern (entity creation), and it is doing so by knowing the concrete details of entity construction. What abstraction might sit between a service and the act of building a new entity?

---

## Design Patterns Worth Exploring

### Unit of Work

**The problem it solves:** `CreateActAsync` can call `GetByIdAsync` on the musician repository and `AddEntityAsync` on the act repository — each of which calls `SaveChangesAsync()` on the `DataContext` independently. If the act save fails after the musician operations, there is no coordinated rollback.

**The pattern:** A `IUnitOfWork` interface exposes all repositories and a single `CommitAsync()` method. Services receive the unit of work rather than individual repositories, and call `CommitAsync()` once at the end. EF Core's `DbContext` already implements this internally — the question is whether services know about it or are shielded from it.

> Relevant reading: "Unit of Work" in Martin Fowler's _Patterns of Enterprise Application Architecture_. Look at how EF Core's `DbContext` is itself a Unit of Work.

---

### Generic Validation Filter (Strategy / Template Method)

**The problem it solves:** Two structurally identical filter classes exist for Act and Album update validation. Adding a third entity means copying a third class. There is no shared extension point.

**The pattern:** A single generic `UpdateIdValidationFilter<TRequest>` could use a generic type constraint (e.g., `where TRequest : IHasId`) and a configured argument key name. One class, one place to extend.

> This could use either a **Strategy** (inject the extraction logic) or a **Template Method** (subclass only overrides the argument key). Which fits better given the ASP.NET Core filter model?

---

### Factory / Static Factory Method

**The problem it solves:** `new MusicianEntity { Id = Guid.NewGuid().ToString(), IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }` appears in multiple services. The boilerplate for `Id`, `IsActive`, `CreatedAt`, and `UpdatedAt` is always identical.

**The pattern:** A static factory method on the entity centralizes construction. `MusicianEntity.Create(name)` handles the infrastructure fields internally — callers only provide the domain values. If the ID generation strategy ever changes, there is one place to update.

---

### Specification Pattern

**The problem it solves:** Query logic is embedded directly in repository methods. As filtering needs grow — "active acts only," "acts with albums after 2020," "acts of type Band" — you either add new repository methods for every combination or accumulate parameters over time.

**The pattern:** A `Specification<T>` encapsulates a query predicate as an object. Repositories expose a single `GetAsync(ISpecification<T>)` method. Specifications can be composed. The repository stays stable; query logic lives in composable, testable objects.

> This works especially well with EF Core's `IQueryable<T>` since specifications can be translated to SQL.

---

### Mediator (MediatR)

**The problem it solves:** As the API grows, controllers directly call services for every operation. Adding cross-cutting behavior — logging every write, validating every command, caching every read — requires modifying every service or controller individually.

**The pattern:** Controllers send a `Command` or `Query` object to a mediator. Pipeline behaviors intercept every command/query, enabling logging, validation, and caching to be added once without touching existing handlers.

> Look at the **MediatR** library and Jimmy Bogard's writing on the mediator pattern in .NET.

---

### Decorator

**The problem it solves:** Logging exists only at the controller boundary. Adding it to services means injecting `ILogger<T>` into every service class and duplicating the same cross-cutting concern.

**The pattern:** A decorator wraps a service implementation and adds behavior around the core logic without the controller knowing which implementation it has. ASP.NET Core's DI container supports decorator registration via `Scrutor`.

---

### Summary Table

| Pattern                   | Problem Addressed                       | Effort | Impact                                |
| ------------------------- | --------------------------------------- | ------ | ------------------------------------- |
| Generic Validation Filter | 2 structurally identical filter classes | Low    | Reduces duplication, single fix point |
| Static Factory Method     | Entity construction duplication         | Low    | Reduces noise, centralizes ID logic   |
| Unit of Work              | No transaction coordination             | Medium | Data integrity                        |
| Specification             | Query logic scattered in repos          | Medium | Scalable filtering                    |
| Decorator                 | No logging in services                  | Medium | Observability                         |
| Mediator                  | Controllers tightly coupled to services | High   | Full pipeline behaviors, testability  |
