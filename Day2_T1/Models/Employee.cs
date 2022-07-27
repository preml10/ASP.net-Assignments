using System.ComponentModel.DataAnnotations;
namespace Day1_T1.Models
{
    public class Employee
    {
        public int E_Id { get; set; }
        [Required]
        public string E_Name { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
        public int Dept_No { get; set; }

    }
}
