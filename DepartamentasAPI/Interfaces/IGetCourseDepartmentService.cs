using DepartamentasAPI.Models;

namespace DepartamentasAPI.Interfaces
{
    public interface IGetCourseDepartmentService
    {
        //public List<DepartCoursStud> GetAllItems();
        //public int CreateItem(string depname, decimal price, DateTime dateCreated);
        //public int UpdateItems(int itemId, string firstName, decimal price, DateTime dateCreated);
        public IEnumerable<GetCourseDepartment> GetCourseByDepartmentId(int departmentid);
        //public int DeleteById(int itemId);
    }
}
