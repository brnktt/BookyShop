using System.ComponentModel.DataAnnotations;

namespace BookyShopWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
