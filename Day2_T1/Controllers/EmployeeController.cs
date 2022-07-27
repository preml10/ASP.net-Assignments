using Microsoft.AspNetCore.Mvc;
using Day1_T1.Models;
using System.Collections.Generic;
using System.Linq;



namespace Day1_T1.Controllers
{
    public class EmployeeController : Controller
    {
        Employee_CRUD context = new Employee_CRUD();
        public IActionResult Employee_Page()
        {
            List<Employee> employees = context.GetAllDetails();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            if(ModelState.IsValid == true)
            {
                context.AddEmployee(obj);
                return RedirectToAction("Employee_Page");
            }
            else
            {
                ViewBag.RequestType = Request.Method;
                ViewBag.ErrorMessage = "Invalid Input";
                return View();

            }
        }
        public IActionResult Details(int id)
        {
            Employee obj = context.GetEmployeeByID(id);
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee obj = context.GetEmployeeByID(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            if (ModelState.IsValid == true)
            {
                context.UpdateDetails(obj);
                return RedirectToAction("Employee_Page");
            }
            else
            {
                ViewBag.RequestType = Request.Method;
                ViewBag.ErrorMessage = "Invalid Input";
                return View();

            }

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee obj = context.GetEmployeeByID(id);
            return View(obj);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            
                context.DeleteEmployee(id);
                return RedirectToAction("Employee_Page");
            

        }


    }
}
