using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ChefNDishes.Views.Home
{
    public class Dishes : PageModel
    {
        private readonly ILogger<Dishes> _logger;

        public Dishes(ILogger<Dishes> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}