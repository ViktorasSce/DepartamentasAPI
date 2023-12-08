namespace DepartamentasAPI.Models
{
    public class GetCourseStudent
    {
        public int studentid { get; set; }
        public int courseid { get; set; }
        public string courname { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
