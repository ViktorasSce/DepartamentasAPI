using DepartamentasAPI.Models;

namespace DepartamentasAPI.Interfaces
{
    public interface IGetCourseStudentRepository
    {
        //public IEnumerable<DepartCoursStud> GetAllItems();
        //public int CreateItem(string depname, decimal price, DateTime dateCreated);
        //public int UpdateItems(int itemId, string name, decimal price, DateTime dateCreated);
        public IEnumerable<GetCourseStudent> GetCourseByStudentId(int studentid);
        //public int DeleteById(int itemId);
    }
}
