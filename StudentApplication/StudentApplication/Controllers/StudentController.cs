using Microsoft.AspNetCore.Mvc;
using Mysqlx.Crud;
using StudentApplication.Models;
using StudentApplication.Services;

namespace StudentApplication.Controllers
{
    public class StudentController : Controller
    {
        public IStudentService StudentService { get; set; }

        public StudentController(IStudentService studentService)
        {
            StudentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddStudent(int id, string name, string email, string phone, string address, string admission_date, double fees, bool status)
        {
            DateOnly aDate=DateOnly.Parse(admission_date);
            Students students = new Students(id,name,email,phone,address,aDate,fees,status);
            StudentService.Insert(students);
            return View();  
        }
        [HttpGet]
        public IActionResult GetAllStudent()
        {
            List<Students> students = StudentService.GetAll();
            ViewData["catalog"]=(students);
            return View();
        }
        [HttpGet]
        public IActionResult GetById()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetById(int id)
        {
            Students students=StudentService.GetById(id);
            ViewData["catalog"]=(students);
            return View();
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            StudentService.Delete(id);
            return RedirectToAction("Index","Home");
        }
    }
}
