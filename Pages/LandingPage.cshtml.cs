using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApp1.Pages
{
    
    public class LandingPageModel : PageModel
    {
        private readonly ILogger<LandingPageModel> _logger;

        public LandingPageModel(ILogger<LandingPageModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            

        }
    }
}
