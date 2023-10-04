using Exam.Entities;
using Exam.Models.Department;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DataContext _context;

        public DepartmentController(DataContext context) // rejlection: 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentViewModel model)
        {

            if (ModelState.IsValid)
            {
                _context.Departments.Add(new Department
                {
                    name = model.name,
                    code = model.code,
                    location = model.location,
                    numberOfPersonals = model.numberOfPersonals,
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _context.Departments.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }



            return View(new DepartmentEditModel
            {
                id = product.id,
                name = product.name,
                code = product.code,
                location = product.location,
                numberOfPersonals = product.numberOfPersonals,
            });
        }
        [HttpPost]
        public IActionResult Edit(DepartmentEditModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Update(new Department
                {
                    id = model.id,
                    name = model.name,
                    code = model.code,
                    location = model.location,
                    numberOfPersonals = model.numberOfPersonals,
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Department department = _context.Departments.Find(id);
            if (department == null)
            {
                return NotFound();
            }
            _context.Departments.Remove(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
