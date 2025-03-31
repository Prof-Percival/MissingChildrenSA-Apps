using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;

namespace MCSA_API.Controllers;

[ApiController]
public class BaseApiController : Controller
{
    protected IActionResult StatusCode(HttpStatusCode httpStatusCode)
    {
        return base.StatusCode((int)httpStatusCode);
    }

    internal ObjectResult FailedRequest(HttpStatusCode httpStatusCode, string message)
    {
        return new ObjectResult(new
        {
            message,
            modelState = ToModelStateDictionary(ModelState)
        })
        {
            StatusCode = (int)httpStatusCode
        };
    }

    internal ObjectResult BadRequest(string message = "The request is invalid.")
    {
        return new ObjectResult(new
        {
            message,
            modelState = ToModelStateDictionary(ModelState)
        })
        {
            StatusCode = (int)HttpStatusCode.BadRequest
        };
    }

    protected ObjectResult Unauthorized(string value)
    {
        return new ObjectResult(new
        {
            message = value
        })
        {
            StatusCode = (int)HttpStatusCode.Unauthorized
        };
    }

    protected ObjectResult NotFound(string value)
    {
        return new ObjectResult(new
        {
            message = value
        })
        {
            StatusCode = (int)HttpStatusCode.NotFound
        };
    }

    private Dictionary<string, string[]> ToModelStateDictionary(ModelStateDictionary modelState)
    {
        if (modelState.ErrorCount > 0)
        {
            return modelState
                .Where(item => item.Value.Errors.Any())
                .ToDictionary(
                item => CamelCase(item.Key),
                item => item.Value.Errors.Select(error => error.ErrorMessage).ToArray());
        }

        return null;
    }

    private static string CamelCase(string value)
    {
        if (value?.Length > 0)
        {
            return char.ToLowerInvariant(value[0]) + value[1..];
        }

        return value;
    }
}
