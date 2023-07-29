using EmployeeManagement.Api.Dtos;
using EmployeeManagement.Api.Models;

namespace EmployeeManagement.Api.Services
{
    public interface IEmployeeRepository
    {
        // contracts
        string AddEmployee(EmployeeDto employee);
        string DeleteEmployee();
        List<Employee> GetAll(); // pagination
        void Update();

        Employee GetById(int id);
    }
}
