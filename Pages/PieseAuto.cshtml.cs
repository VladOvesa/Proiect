using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect.Models;

namespace Proiect.Pages
{
    public class PieseAutoModel : PageModel
    {
        public List<PieseModel> fakePieseDB = new List<PieseModel>()
        {
            new PieseModel()
            {
                ImageTitle="Electromotor" ,
                PieseNume="Electromotor",
                BasePret=100
            }
        };

                
        public void OnGet()
        {
        }
    }
}
