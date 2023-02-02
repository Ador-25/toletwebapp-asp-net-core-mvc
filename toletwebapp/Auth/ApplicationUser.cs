using Microsoft.AspNetCore.Identity;

namespace toletwebapp.Auth
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }
    }

}
