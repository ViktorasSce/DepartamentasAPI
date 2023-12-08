using Dapper;
using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Models;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DepartamentasAPI.Repositories
{
    public class StudentDepartmentRepository : IStudentDepartmentRepository
    {
        private readonly IDbConnection _connection;

        public StudentDepartmentRepository(IConfiguration configuration, IDbConnection connection)
        {
            //_configuration = configuration;
            _connection = connection;
        }
        //public int CreateItem(string depname, decimal price, DateTime dateCreated)
        //{
        //    //using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreConnection")))
        //    {
        //        string sql = $"with rows as (INSERT INTO department (depname) VALUES(@depName) RETURNING id) INSERT INTO courses_students (department_id) SELECT id FROM rows;";

        //        var queryArguments = new
        //        {
        //            depname = depname
        //        };

        //        Console.WriteLine(queryArguments);

        //        return _connection.Execute(sql, queryArguments);
        //    }
        //}

        //public IEnumerable<DepartCoursStud> GetAllItems()
        //{
        //    //using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreConnection")))
        //    {
        //        return _connection.Query<DepartCoursStud>("SELECT * FROM ShopItem");

        //    }
        //}
        public IEnumerable<StudentDepartment> GetStudentByDepartmentId(int departmentid)
        {
            try
            {
                //using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreConnection")))
                {
                    string sql = "SELECT public.students.studname, public.depcourstud.departmentid, public.depcourstud.studentid FROM public.students JOIN public.depcourstud ON public.students.id = public.depcourstud.studentid WHERE departmentid = @departmentid";

                    var queryArguments = new
                    {
                        departmentid = departmentid
                    };
                    var result = _connection.Query<StudentDepartment>(sql, queryArguments);

                    if(result != null && result.Any())
                    {
                        return _connection.Query<StudentDepartment>(sql, queryArguments);

                    }
                    throw new Exception("No department");
                   

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //public int DeleteById(int itemId)
        //{
        //    //using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreConnection")))
        //    {
        //        string sql = "DELETE FROM ShopItem WHERE itemId = @itemId";
        //        var queryArguments = new
        //        {
        //            itemId = itemId
        //        };
        //        return _connection.Execute(sql, queryArguments);

        //    }
        //}
        //public int UpdateItems(int itemId, string firstName, decimal price, DateTime dateCreated)
        //{
        //    //using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreConnection")))
        //    {
        //        string sql = "UPDATE ShopItem SET FirstName = @firstName, Price = @price, DateCreated = @dateCreated WHERE ItemId = @itemId";
        //        var queryArguments = new
        //        {
        //            itemId = itemId,
        //            firstName = firstName,
        //            price = price,
        //            dateCreated = dateCreated
        //        };

        //        return _connection.Execute(sql, queryArguments);
        //    }
        //}
    }
}
