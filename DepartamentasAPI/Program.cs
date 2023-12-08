using Npgsql;
using DepartamentasAPI.Interfaces;
using DepartamentasAPI.Repositories;
using DepartamentasAPI.Services;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DbUp;
using System.Reflection;
using Serilog;
using DepartamentasAPI.Models;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<DepartamentasAPIContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreConnection") ?? throw new InvalidOperationException("Connection string 'DepartamentasAPIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ICreateDepartmentRepository, DepartamentasAPI.Repositories.CreateDepartmentRepository>();
builder.Services.AddTransient<ICreateDepartmentService, DepartamentasAPI.Services.CreateDepartmentService>();
builder.Services.AddTransient<IStudentDepartmentRepository, StudentDepartmentRepository>();
builder.Services.AddTransient<IStudentDepartmentService, StudentDepartmentService>();
builder.Services.AddTransient<IGetCourseDepartmentRepository, GetCourseDepartmentRepository>();
builder.Services.AddTransient<IGetCourseDepartmentService, GetCourseDepartmentService>();
builder.Services.AddTransient<IGetCourseStudentRepository, GetCourseStudentRepository>();
builder.Services.AddTransient<IGetCourseStudentService, GetCourseStudentService>();

var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

string dbConnectionString = builder.Configuration.GetConnectionString("PostgreConnection");

EnsureDatabase.For.PostgresqlDatabase(dbConnectionString);

var upgrader =
       DeployChanges.To
           .PostgresqlDatabase(dbConnectionString)
           .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
           .LogToConsole()
           .Build();

var result = upgrader.PerformUpgrade();

// Inject IDbConnection, with implementation from SqlConnection class.

builder.Services.AddTransient<IDbConnection>(sp => new NpgsqlConnection(dbConnectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
