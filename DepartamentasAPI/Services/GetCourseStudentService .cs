using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Models;
using DepartamentasAPI.Repositories;

namespace DepartamentasAPI.Services
{
    public class GetCourseStudentService : IGetCourseStudentService
    {
        private readonly IGetCourseStudentRepository _getCourseStudentRepository;
        public GetCourseStudentService(IGetCourseStudentRepository getCourseStudentRepository)
        {
            _getCourseStudentRepository = getCourseStudentRepository;
        }

        //public List<DepartCoursStud> GetAllItems()
        //{
        //    return _departCoursStudRepository.GetAllItems().ToList();
        //}
        public IEnumerable<GetCourseStudent> GetCourseByStudentId(int studentid)
        {
            return _getCourseStudentRepository.GetCourseByStudentId(studentid).ToList();
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
