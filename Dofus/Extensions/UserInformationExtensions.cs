using System.Security.Claims;

namespace Dofus.Extensions
{
    public class UserInfo
    {
        public string UserId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }

    public static class UserInformationExtensions
    {
        public static UserInfo RetrieveUserInfo(this ClaimsPrincipal user)
        {
            return new UserInfo
            {
                UserId = user.FindFirstValue("uid"),
                Fullname = user.FindFirstValue(ClaimTypes.GivenName),
                Username = user.FindFirstValue(ClaimTypes.NameIdentifier),
                Email = user.FindFirstValue(ClaimTypes.Email),
            };
        }
    }
}
