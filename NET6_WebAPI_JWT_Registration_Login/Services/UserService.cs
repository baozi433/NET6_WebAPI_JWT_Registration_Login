using NET6_WebAPI_JWT_Registration_Login.Models;
using System.Security.Claims;

namespace NET6_WebAPI_JWT_Registration_Login.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }
        public string GetUserRole()
        {
            var result = string.Empty;
            if(httpContextAccessor.HttpContext != null)
            {
                result = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
            }
            return result;
        }
    }
}
