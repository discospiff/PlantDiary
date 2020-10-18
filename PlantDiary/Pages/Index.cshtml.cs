using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PlantDiary.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string brandName = Request.Query["BrandName"];
            if (brandName == null || brandName.Length == 0)
            {
                int yearStarted = 2006;
                string title = "My Plant Diary, Established ";
                // assigning a default value to Brand Name if not populated from GET params
                brandName = title + yearStarted;
            }
            // Pass the data to our UI Page.
            ViewData["brand"] = brandName;
        }
    }
}
