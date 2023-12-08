namespace DepartamentasAPI.Models
{
    public class GetCourseDepartment
    {
        public int departmentid { get; set; }
        public int courseid { get; set; }
        public string courname { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
