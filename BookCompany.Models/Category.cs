using System.ComponentModel.DataAnnotations;

namespace BookCompany.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name="Category Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
