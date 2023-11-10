using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ChefNDishes.Models
{
    public class CheckAgeAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value is DateOnly)
            {
                DateOnly date = (DateOnly)value;
                DateOnly now = DateOnly.FromDateTime(DateTime.Now);
                if(date > now)
                {
                    return new ValidationResult("that is not a valid date!");
                }
                int age = now.Year - date.Year;
                if(date > now.AddYears(-age))
                {
                    age--;
                }
                if(age < 18)
                {
                    return new ValidationResult("chef must be 18 or older!");
                }
                return ValidationResult.Success;
                
                
            } return new ValidationResult("that is not a valid date!");
        }
    }
}