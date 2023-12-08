using DepartamentasAPI.Controllers;
using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Models;
using DepartamentasAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DepartamentasAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CreateDepartmentController : ControllerBase
    {
        private readonly ICreateDepartmentService _createDepartmentService;

        public CreateDepartmentController(ICreateDepartmentService createDepartmentService)
        {
            _createDepartmentService = createDepartmentService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartment([FromBody] CreateDepartment createDepartment)
        {
            try
            {
                return Ok(_createDepartmentService.CreateDepartment(createDepartment.id, createDepartment.depname, createDepartment.DateCreated));
            }
            catch (Exception)
            {

                throw;
            }

        }
        //[HttpGet]
        //public async Task<IActionResult> GetAllItems()
        //{
        //    try
        //    {
        //        return Ok(_departCoursStudService.GetAllItems());
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //[HttpPost]
        //public async Task<IActionResult> GetById([FromBody] DepartCoursStud departCoursStud)
        //{
        //    try
        //    {
        //        return Ok(_departCoursStudService.GetById(departCoursStud.ItemId));
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeleteById([FromBody] DepartCoursStud departCoursStud)
        //{
        //    try
        //    {
        //        if (false)
        //        {
        //            throw new Exception("Something goes wrong");
        //        }
        //        return Ok(_departCoursStudService.DeleteById(departCoursStud.ItemId));
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //        throw;
        //    }

        //}

        //[HttpPut]
        //public async Task<IActionResult> UpdateItems([FromBody] DepartCoursStud departCoursStud)
        //{
        //    try
        //    {
        //        return Ok(_departCoursStudService.UpdateItems(departCoursStud.ItemId, departCoursStud.Name, departCoursStud.Price, departCoursStud.DateCreated));
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}

