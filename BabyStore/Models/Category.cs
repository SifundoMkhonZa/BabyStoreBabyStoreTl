using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BabyStore.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "The category name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessageResourceName = "please enter between 3 and 50 characters in length")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Name must beginning with a capital letter and made up of letters and spaces only")] 
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        public virtual ICollection<Product>Products { get; set; }
    }
}