using EmployeeManagement.Api.Dtos;
using EmployeeManagement.Api.Models;
using EmployeeManagement.Api.Services;
using Microsoft.AspNetCore.Identity;
using System.Text;

namespace EmployeeManagement.Api.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public UserRepository(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<string> AddUser(CreateUserDto createUser)
        {

            var userRequest = new AppUser
            {
                Email = createUser.Email,
                FirstName = createUser.FirstName,
                LastName = createUser.LastName,
                UserName = createUser.UserName,
                PhoneNumber = createUser.PhoneNumber,
            };

            var addUserResponse = await _userManager.CreateAsync(userRequest, "Password@123");

            if (addUserResponse.Succeeded)
                return "Registration successfully";

            var error = addUserResponse.Errors.FirstOrDefault(x => x.Description != null);

            return $"Registration not successful, please try again: Error = {error.Description}";
        }

        public async Task<string> Login(LoginDto login)
        {
            var loginResponse = await _signInManager.PasswordSignInAsync(login.Email, login.Password, true, false);

            if (loginResponse.Succeeded)
                return "Login successfull";

            return "Incorrect username or password";
        }
    }
}
