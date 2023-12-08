using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepartamentasAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GetCourseDepartmentController : ControllerBase
    {
        private readonly IGetCourseDepartmentService _getCourseDepartmentService;

        public GetCourseDepartmentController (IGetCourseDepartmentService getCourseDepartmentService)
        {
            _getCourseDepartmentService = getCourseDepartmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCourseByDepartmentId([FromBody] GetCourseDepartment getCourseDepartment)
        {
            try
            {
                return Ok(_getCourseDepartmentService.GetCourseByDepartmentId(getCourseDepartment.departmentid));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
