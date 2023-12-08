using DepartamentasAPI.Models;

namespace DepartamentasAPI.Interfaces
{
    public interface IStudentDepartmentService
    {
        //public List<DepartCoursStud> GetAllItems();
        //public int CreateItem(string depname, decimal price, DateTime dateCreated);
        //public int UpdateItems(int itemId, string firstName, decimal price, DateTime dateCreated);
        public IEnumerable<StudentDepartment> GetStudentByDepartmentId(int departmentid);
        //public int DeleteById(int itemId);
    }
}
