using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlantDiary.Pages
{
    public class AutoCompletePlantNamesModel : PageModel
    {
        private IList<string> plantNames = new List<string>();

        public JsonResult OnGet(String term)
        {
            plantNames.Add("Redbud");
            plantNames.Add("Red Maple");
            plantNames.Add("Red Oak");
            plantNames.Add("Red Rose");
            plantNames.Add("Red Lily");

            IList<string> matchingPlantNames = new List<string>();

            // iterate over all plant names.
            foreach(string plantName in plantNames) {
                if (plantName.Contains(term)) {
                    matchingPlantNames.Add(plantName);
                }
            }

            return new JsonResult(matchingPlantNames);
        }
    }
}
