using Microsoft.AspNetCore.Identity;

namespace EmployeeManagement.Api.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class UserRole : IdentityRole
    {
        public string RoleName { get; set; }
    }
}


