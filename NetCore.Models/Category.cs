
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation; // referenced for [ValidateNever], using project setting
using System.ComponentModel.DataAnnotations;

namespace NetCore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Category Name")]
        public required string Name { get; set; }

        [Range(0,100, ErrorMessage ="Range must be between 0 and 100!")]
        [Display(Name = "Display Order")]
        //[ValidateNever]
        public int? DisplayOrder { get; set; }
    }
}
