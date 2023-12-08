using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepartamentasAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GetCourseStudentController : ControllerBase
    {
        private readonly IGetCourseStudentService _getCourseStudentService;

        public GetCourseStudentController(IGetCourseStudentService getCourseStudentService)
        {
            _getCourseStudentService = getCourseStudentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCourseByStudentId([FromBody] GetCourseStudent getCourseStudent)
        {
            try
            {
                return Ok(_getCourseStudentService.GetCourseByStudentId(getCourseStudent.studentid));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}