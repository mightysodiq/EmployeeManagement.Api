using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Api.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string IdNumber { get; set; } // 
        public string Department { get; set; }
    }
}
