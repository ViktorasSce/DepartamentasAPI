using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Models;
using DepartamentasAPI.Repositories;

namespace DepartamentasAPI.Services
{
    public class StudentDepartmentService : IStudentDepartmentService
    {
        private readonly IStudentDepartmentRepository _studentDepartmentRepository;
        public StudentDepartmentService(IStudentDepartmentRepository studentDepartmentRepository)
        {
            _studentDepartmentRepository = studentDepartmentRepository;
        }

        //public List<DepartCoursStud> GetAllItems()
        //{
        //    return _departCoursStudRepository.GetAllItems().ToList();
        //}
        public IEnumerable<StudentDepartment> GetStudentByDepartmentId(int departmentid)
        {
            return _studentDepartmentRepository.GetStudentByDepartmentId(departmentid).ToList();
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
