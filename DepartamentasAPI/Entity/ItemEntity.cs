using DepartamentasAPI.Entity;

namespace DepartamentasAPI.Entity
{
    public class ItemEntity : BaseEntity
    {
        public int ItemId { get; set; }
        public string depname { get; set; }
        public decimal Price { get; set; }

    }
}
