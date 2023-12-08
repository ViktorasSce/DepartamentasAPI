namespace DepartamentasAPI.Models
{
    public class StudentDepartment
    {
        public int departmentid { get; set; }
        public int studentid { get; set; }
        public string studname { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
