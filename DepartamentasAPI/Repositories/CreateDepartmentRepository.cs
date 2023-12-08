using Dapper;
using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Models;
using System.Collections.Generic;
using System.Data;

namespace DepartamentasAPI.Repositories
{
    public class CreateDepartmentRepository : ICreateDepartmentRepository
    {
        //private readonly IConfiguration _configuration;
        private readonly IDbConnection _connection;

        public CreateDepartmentRepository(IConfiguration configuration, IDbConnection connection)
        {
            //_configuration = configuration;
            _connection = connection;
        }
        public int CreateDepartment(int id, string depname, DateTime dateCreated)
        {
            //using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreConnection")))
            {
                string sql = $"with rows as (INSERT INTO department (depname) VALUES(@depName) RETURNING id) INSERT INTO courses_students (department_id) SELECT id FROM rows;";

                var queryArguments = new
                {
                    id = id,
                    depname = depname
                };

                return _connection.Execute(sql, queryArguments);
            }
        }

        //public IEnumerable<DepartCoursStud> GetAllItems()
        //{
        //    //using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreConnection")))
        //    {
        //        return _connection.Query<DepartCoursStud>("SELECT * FROM ShopItem");

        //    }
        //}
        //public IEnumerable<DepartCoursStud> GetById(int itemId)
        //{
        //    //using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreConnection")))
        //    {
        //        string sql = "SELECT * FROM ShopItem WHERE ItemId = @itemId";
        //        var queryArguments = new
        //        {
        //            itemId = itemId
        //        };
        //        return _connection.Query<DepartCoursStud>(sql, queryArguments);

        //    }
        //}
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
