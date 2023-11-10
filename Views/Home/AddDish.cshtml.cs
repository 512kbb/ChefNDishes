using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ChefNDishes.Views.Home
{
    public class AddDish : PageModel
    {
        private readonly ILogger<AddDish> _logger;

        public AddDish(ILogger<AddDish> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}