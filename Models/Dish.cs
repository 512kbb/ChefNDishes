using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChefNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        [Required]
        [MinLength(2)]
        [DisplayName("Name of Dish")]
        public string? DishName { get; set; }
        [Required]
        [Range(1, 5)]
        public int Tastiness { get; set; }
        [Required]
        [Range(1, 10000)]
        [DisplayName("# of Calories")]
        public int Calories { get; set; }
        [ForeignKey("Chef")]
        [DisplayName("Chef Name")]
        public int ChefId { get; set; }
        public Chef? Creator { get; set; }
    }
}