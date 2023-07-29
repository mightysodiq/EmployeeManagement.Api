using EmployeeManagement.Api.Dtos;

namespace EmployeeManagement.Api.Services
{
    public interface IUserRepository
    {
        Task<string> AddUser(CreateUserDto createUser);
        Task<string> Login(LoginDto login);
    }
}
