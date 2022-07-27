using Microsoft.EntityFrameworkCore;
using WebApplication2.Controllers;
using WebApplication2.Models;


using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models

{
    public class Employee
    {
        
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
        public int DeptNo { get; set; }
    }

    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }

    }
}
