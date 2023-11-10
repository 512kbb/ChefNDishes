using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ChefNDishes.Models
{
    public class ChefsNDishesContext : DbContext
    {
        public ChefsNDishesContext(DbContextOptions options) : base(options) { }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}