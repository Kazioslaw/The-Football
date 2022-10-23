namespace TfcDomain.Models
{
    public class EmployeePosition : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public EmployeePosition(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public ICollection<Employee> Employees { get; set; }
    }
}