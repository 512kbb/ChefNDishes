using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ChefNDishes.Views.Home
{
    public class AddChef : PageModel
    {
        private readonly ILogger<AddChef> _logger;

        public AddChef(ILogger<AddChef> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}