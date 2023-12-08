using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Models;
using DepartamentasAPI.Repositories;

namespace DepartamentasAPI.Services
{
    public class CreateDepartmentService : ICreateDepartmentService
    {
        private readonly ICreateDepartmentRepository _createDepartmentRepository;
        public CreateDepartmentService(ICreateDepartmentRepository createDepartmentRepository)
        {
            _createDepartmentRepository = createDepartmentRepository;
        }

        //public List<DepartCoursStud> GetAllItems()
        //{
        //    return _departCoursStudRepository.GetAllItems().ToList();
        //}
        //public IEnumerable<DepartCoursStud> GetById(int itemId)
        //{
        //    return _departCoursStudRepository.GetById(itemId).ToList();
        //}
        //public int DeleteById(int itemId)
        //{
        //    return _departCoursStudRepository.DeleteById(itemId);
        //}

        public int CreateDepartment(int id, string depname, DateTime dateCreated)
        {
            return _createDepartmentRepository.CreateDepartment(id, depname, dateCreated);
        }

        //public int UpdateItems(int itemId, string firstName, decimal price, DateTime dateCreated)
        //{
        //    return _departCoursStudRepository.UpdateItems(itemId, firstName, price, dateCreated);
        //}
    }
}
