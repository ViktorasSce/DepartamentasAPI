namespace DepartamentasAPI.Models
{
    public class CreateDepartment
    {
        public int id { get; set; }
        public string depname { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
