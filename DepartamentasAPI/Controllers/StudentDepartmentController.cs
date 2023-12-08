using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Models;
using DepartamentasAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DepartamentasAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentDepartmentController : ControllerBase
    {
        private readonly IStudentDepartmentService _studentDepartmentService;

        public StudentDepartmentController(IStudentDepartmentService studentDepartmentService)
        {
            _studentDepartmentService = studentDepartmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudentByDepartmentId([FromBody] StudentDepartment studentDepartment)
        {
            try
            {
                return Ok(_studentDepartmentService.GetStudentByDepartmentId(studentDepartment.departmentid));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
