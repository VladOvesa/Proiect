using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.StocPieses
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DetailsModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

      public StocPiese StocPiese { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.StocPiese == null)
            {
                return NotFound();
            }

            var stocpiese = await _context.StocPiese.FirstOrDefaultAsync(m => m.ID == id);
            if (stocpiese == null)
            {
                return NotFound();
            }
            else 
            {
                StocPiese = stocpiese;
            }
            return Page();
        }
    }
}
