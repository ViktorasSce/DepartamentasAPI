using Dapper;
using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Models;
using System.Data;

namespace DepartamentasAPI.Repositories
{
    public class GetCourseStudentRepository : IGetCourseStudentRepository
    {
        private readonly IDbConnection _connection;

        public GetCourseStudentRepository(IConfiguration configuration, IDbConnection connection)
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
        public IEnumerable<GetCourseStudent> GetCourseByStudentId(int studentid)
        {
            try
            {
                //using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreConnection")))
                {
                    string sql = "SELECT public.courses.courname, public.depcourstud.studentid, public.depcourstud.courseid FROM public.courses JOIN public.depcourstud ON public.courses.id = public.depcourstud.courseid WHERE studentid = @studentid;";

                    var queryArguments = new
                    {
                        studentid = studentid
                    };
                    var result = _connection.Query<GetCourseStudent>(sql, queryArguments);

                    if (result != null && result.Any())
                    {
                        return _connection.Query<GetCourseStudent>(sql, queryArguments);

                    }
                    throw new Exception("No course");


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
