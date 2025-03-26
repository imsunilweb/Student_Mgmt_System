using Microsoft.AspNetCore.Mvc;
using Student_Mgmt_System.Models;
using Student_Mgmt_System.UnitOfWorkPattern;

namespace Student_Mgmt_System.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _unitOfWork.Students.GetAllStudentsAsync();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Students.AddStudentAsync(student);
                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
