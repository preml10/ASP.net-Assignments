namespace Day1_T1.Models
{
    public class Employee_CRUD
    {
        public static List<Employee> employees = new List<Employee>();
        public Employee_CRUD()
        {
            employees = new List<Employee> {
                new Employee() { E_Id = 1, E_Name = "John" , Job = "SWE" , Salary = 25000 , Dept_No = 12} ,
                new Employee() { E_Id = 2, E_Name = "Sarah" , Job = "Production" , Salary = 20000 , Dept_No = 14}, 
                new Employee() { E_Id = 3, E_Name = "Sid" , Job = "Analyst" , Salary = 40000 , Dept_No = 20}
            
            
            };
        }
        public List<Employee> GetAllDetails()
        {
            return employees;
        }

        public Employee GetEmployeeByID(int id)
        {
            return employees.Find(item => item.E_Id == id);
        }

        public void AddEmployee(Employee obj)
        {
            employees.Add(obj);
        }

        public void DeleteEmployee(int id)
        {
            Employee obj = employees.Find(item => item.E_Id == id);
            employees.Remove(obj);
        }
        public void UpdateDetails(Employee update)
        {
            Employee obj = employees.Find(item => item.E_Id == update.E_Id);
            employees.Remove(obj);
            employees.Add(update);
        }
    }
}
