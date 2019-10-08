using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GCCoffeeShop.Models
{
    public class UserItems
    {
        [Key]
       [Required]
        [MinLength(3)]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(1, 150, ErrorMessage = "Please enter correct value from 1 to 150")]        
        public float Price { get; set; }
        [Required]
        
        [Range(1, 1000, ErrorMessage = "Please enter correct value from 1 to 1000")]
        public int Quantity { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(2000, ErrorMessage = "Do not enter more than 2000 characters")]
        public string Description { get; set; }
    }
}
