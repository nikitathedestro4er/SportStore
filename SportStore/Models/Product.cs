using System;
using System.ComponentModel.DataAnnotations;

namespace SportStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }
        
        [Required]
        [Range(0.01,Double.MaxValue,ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }
        
        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }
    }
}