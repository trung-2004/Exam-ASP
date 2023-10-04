using Exam.Entities;
using Exam.Models.Department;
using Exam.Models.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exam.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DataContext _context;

        public EmployeeController(DataContext context) // rejlection: 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }
        public IActionResult Create()
        {
            var Departments = _context.Departments.ToList();
            ViewBag.Departments = Departments;
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel model)
        {

            if (ModelState.IsValid)
            {
                _context.Employees.Add(new Employee
                {
                    name = model.name,
                    code = model.code,
                    rank = model.rank,
                    department_id = model.department_id,
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            var Departments = _context.Departments.ToList();
            ViewBag.Departments = Departments;

            return View(model);
        }
    }
}
