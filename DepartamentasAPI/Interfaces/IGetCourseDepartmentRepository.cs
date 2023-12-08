using DepartamentasAPI.Models;

namespace DepartamentasAPI.Interfaces
{
    public interface IGetCourseDepartmentRepository
    {
        //public IEnumerable<DepartCoursStud> GetAllItems();
        //public int CreateItem(string depname, decimal price, DateTime dateCreated);
        //public int UpdateItems(int itemId, string name, decimal price, DateTime dateCreated);
        public IEnumerable<GetCourseDepartment> GetCourseByDepartmentId(int departmentid);
        //public int DeleteById(int itemId);
    }
}
