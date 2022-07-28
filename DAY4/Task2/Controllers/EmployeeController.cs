using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Repositries;
using log4net;


namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        //private static readonly ILog Log = LogManager.GetLogger(typeof(EmployeeController));
        
        private readonly ILogger<EmployeeController> _logger;
        [ActivatorUtilitiesConstructor]
        public EmployeeController(ILogger<EmployeeController> logger)
            {
                _logger = logger;
            }
        

        IEmployeeRepo _repository;

        public EmployeeController(IEmployeeRepo repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Employee Page is Processed.");
            _logger.LogError("Error Message");


            List<Employee> emList = _repository.GetAllEmployee();
            return View(emList);

        }

        [HttpGet]
        public IActionResult Create()
        {
            //_logger.LogInformation("Created New Employee.");
            //_logger.LogError("Error Message");


            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
           // _logger.LogInformation("Created New Employee.");
          //  _logger.LogError("Error Message");

            _repository.AddEmployee(obj);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
           // _logger.LogInformation("Details are Processed.");
            //_logger.LogError("Error Message");

            Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            //_logger.LogInformation("Edited Employee Page .");
            //_logger.LogError("Error Message");

            Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            //_logger.LogInformation("Edited Employee Page .");
            //_logger.LogError("Error Message");


            _repository.UpdateEmployee(obj);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            //_logger.LogInformation("Deleted Employee Details.");
            //_logger.LogError("Error Message");

            Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            //_logger.LogInformation("Deleted Employee Details.");
      //      _logger.LogError("Error Message");

            _repository.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
        

    }
}