using IMuDB.Domain.DTOs.Act.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace IMuDB.API.Filters.ValidationFilters
{
    public class ActUpdateRequestIdValidationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            string? routeId = context.ActionArguments["actId"] as string;
            ActUpdateRequest? updateActRequest = context.ActionArguments["updateActRequest"] as ActUpdateRequest;

            if (string.IsNullOrEmpty(routeId) || updateActRequest == null || string.IsNullOrEmpty(updateActRequest?.Id) || routeId != updateActRequest.Id)
            {
                context.ModelState.AddModelError("actId", "Route Id does not match model Id");
                ValidationProblemDetails details = new ValidationProblemDetails(context.ModelState)
                {
                    Status = StatusCodes.Status400BadRequest
                };

                context.Result = new BadRequestObjectResult(details);
            }
        }
    }
}
