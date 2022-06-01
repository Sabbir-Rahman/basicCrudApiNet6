using System.ComponentModel.DataAnnotations;

namespace basicCrudApi
{
    public class Employee
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Comments { get; set; } = string.Empty;
        public int EmployeeTypeId { get; set; }
        public EmployeeType? EmployeeType { get; set; }
    }
}
