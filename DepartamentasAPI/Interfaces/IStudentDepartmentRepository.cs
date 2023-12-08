using DepartamentasAPI.Models;

namespace DepartamentasAPI.Interfaces
{
    public interface IStudentDepartmentRepository
    {
        //public IEnumerable<DepartCoursStud> GetAllItems();
        //public int CreateItem(string depname, decimal price, DateTime dateCreated);
        //public int UpdateItems(int itemId, string name, decimal price, DateTime dateCreated);
        public IEnumerable<StudentDepartment> GetStudentByDepartmentId(int itemId);
        //public int DeleteById(int itemId);
    }
}
