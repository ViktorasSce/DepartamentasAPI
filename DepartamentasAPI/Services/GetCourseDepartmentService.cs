using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Models;
using DepartamentasAPI.Repositories;

namespace DepartamentasAPI.Services
{
    public class GetCourseDepartmentService : IGetCourseDepartmentService
    {
        private readonly IGetCourseDepartmentRepository _getCourseDepartmentRepository;
        public GetCourseDepartmentService(IGetCourseDepartmentRepository getCourseDepartmentRepository)
        {
            _getCourseDepartmentRepository = getCourseDepartmentRepository;
        }

        //public List<DepartCoursStud> GetAllItems()
        //{
        //    return _departCoursStudRepository.GetAllItems().ToList();
        //}
        public IEnumerable<GetCourseDepartment> GetCourseByDepartmentId(int departmentid)
        {
            return _getCourseDepartmentRepository.GetCourseByDepartmentId(departmentid).ToList();
        }
        //public int DeleteById(int itemId)
        //{
        //    return _departCoursStudRepository.DeleteById(itemId);
        //}

        //public int CreateItem(string depname, decimal price, DateTime dateCreated)
        //{
        //    return _departCoursStudRepository.CreateItem(depname, price, dateCreated);
        //}

        //public int UpdateItems(int itemId, string firstName, decimal price, DateTime dateCreated)
        //{
        //    return _departCoursStudRepository.UpdateItems(itemId, firstName, price, dateCreated);
        //}
    }
}
