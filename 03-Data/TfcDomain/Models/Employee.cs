using System.ComponentModel.DataAnnotations.Schema;

namespace TfcDomain.Models
{
    public class Employee : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey(nameof(EmployeePosition))]
        public int EmployeePositionId { get; set; }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, int employeePosition)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeePositionId = employeePosition;
        }

        public EmployeePosition EmployeePosition { get; set; }
    }
}