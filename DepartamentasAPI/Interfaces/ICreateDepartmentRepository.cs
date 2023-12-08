using DepartamentasAPI.Models;

namespace DepartamentasAPI.Interfaces
{
    public interface ICreateDepartmentRepository
    {
        //public IEnumerable<DepartCoursStud> GetAllItems();
        public int CreateDepartment(int id, string depname, DateTime dateCreated);
        //public int UpdateItems(int itemId, string name, decimal price, DateTime dateCreated);
        //public IEnumerable<DepartCoursStud> GetById(int itemId);
        //public int DeleteById(int itemId);
    }
}
