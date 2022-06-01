using System.ComponentModel.DataAnnotations;

namespace basicCrudApi
{
    public class EmployeeType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string EmployeeName { get; set; } = string.Empty;
    }
}
