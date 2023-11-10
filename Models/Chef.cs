using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ChefNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [CheckAge]
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateOnly BirthDate { get; set; }
        public List<Dish> CreatedDishes { get; set; } = new List<Dish>();

        public int CalculateAge()
        {
            DateOnly now = DateOnly.FromDateTime(DateTime.Now);
            int age = now.Year - this.BirthDate.Year;
            if (this.BirthDate > now.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}