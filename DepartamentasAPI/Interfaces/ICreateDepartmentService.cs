using DepartamentasAPI.Models;

namespace DepartamentasAPI.Interfaces
{
    public interface ICreateDepartmentService
    {
        //public List<DepartCoursStud> GetAllItems();
        public int CreateDepartment(int id, string depname, DateTime dateCreated);
        //public int UpdateItems(int itemId, string firstName, decimal price, DateTime dateCreated);
        //public IEnumerable<DepartCoursStud> GetById(int itemId);
        //public int DeleteById(int itemId);
    }
}
