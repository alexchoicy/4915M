using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using Server.Model.Dto;

namespace Server.Helper.HttpError
{
    public class AuthFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool tokenFlag = context.HttpContext.Request.Headers.TryGetValue("Authorization", out StringValues token);

            var ignore = (from a in context.ActionDescriptor.EndpointMetadata
                where a.GetType() == typeof(AllowAnonymousAttribute)
                select a).FirstOrDefault();
            if (ignore != null)
            {
                return;
            }
            if (tokenFlag)
            {
                if (token != "123")
                {
                    context.Result = new JsonResult(new ReturnJson()
                    {
                        HttpStatus = 401,
                        Data = "",
                        Error = "Not Auth"
                    });
                }
            }
            else
            {
                context.Result = new JsonResult(new ReturnJson()
                {
                    HttpStatus = 401,
                    Data = "",
                    Error = "Not Auth"
                });
            }
        }
    }
}
