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
    public class DeleteModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DeleteModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.StocPiese == null)
            {
                return NotFound();
            }
            var stocpiese = await _context.StocPiese.FindAsync(id);

            if (stocpiese != null)
            {
                StocPiese = stocpiese;
                _context.StocPiese.Remove(StocPiese);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
