using DepartamentasAPI.Models;

namespace DepartamentasAPI.Interfaces
{
    public interface IGetCourseStudentService
    {
        //public List<DepartCoursStud> GetAllItems();
        //public int CreateItem(string depname, decimal price, DateTime dateCreated);
        //public int UpdateItems(int itemId, string firstName, decimal price, DateTime dateCreated);
        public IEnumerable<GetCourseStudent> GetCourseByStudentId(int studentid);
        //public int DeleteById(int itemId);
    }
}
