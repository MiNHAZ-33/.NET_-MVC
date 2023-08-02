using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Model.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public String Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,50, ErrorMessage ="Display order must be between 1-50")]
        public int DisplayOrder { get; set; }
    }
}
