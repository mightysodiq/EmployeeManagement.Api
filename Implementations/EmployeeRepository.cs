using EmployeeManagement.Api.Context;
using EmployeeManagement.Api.Dtos;
using EmployeeManagement.Api.Models;
using EmployeeManagement.Api.Services;

namespace EmployeeManagement.Api.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationContext _applicationContext;
        public EmployeeRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public string AddEmployee(EmployeeDto employee)
        {
            // automapper
            var employeeToAdd = new Employee
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PhoneNumber = employee.PhoneNumber,
                Department = employee.Department,
                EmailAddress = employee.EmailAddress,
                IdNumber = employee.IdNumber
            };

            var addToDb = _applicationContext.Employees.Add(employeeToAdd);
            var result = _applicationContext.SaveChanges();

            if (result > 0)
                return "Operation completed";

            return "Operation failed";

        }

        public string DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
