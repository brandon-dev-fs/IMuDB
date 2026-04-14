using IMuDB.Domain.DTOs.Album.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace IMuDB.API.Filters.ValidationFilters
{
    public class AlbumUpdateRequestIdValidationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            string? routeId = context.ActionArguments["albumId"] as string;
            AlbumUpdateRequest? updateAlbumRequest = context.ActionArguments["updateAlbumRequest"] as AlbumUpdateRequest;

            if (string.IsNullOrEmpty(routeId) || updateAlbumRequest == null || string.IsNullOrEmpty(updateAlbumRequest?.Id) || routeId != updateAlbumRequest.Id)
            {
                context.ModelState.AddModelError("albumId", "Route Id does not match model Id");
                ValidationProblemDetails details = new ValidationProblemDetails(context.ModelState)
                {
                    Status = StatusCodes.Status400BadRequest
                };

                context.Result = new BadRequestObjectResult(details);
            }
        }
    }
}
