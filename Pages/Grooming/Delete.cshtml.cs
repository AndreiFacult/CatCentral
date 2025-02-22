using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CatCentral.Data;
using CatCentral.Models;

namespace CatCentral.Pages.Grooming
{
    public class DeleteModel : PageModel
    {
        private readonly CatCentral.Data.CatCentralContext _context;

        public DeleteModel(CatCentral.Data.CatCentralContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Groom Groom { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groom = await _context.Grooming.FirstOrDefaultAsync(m => m.ID == id);

            if (groom == null)
            {
                return NotFound();
            }
            else
            {
                Groom = groom;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groom = await _context.Grooming.FindAsync(id);
            if (groom != null)
            {
                Groom = groom;
                _context.Grooming.Remove(Groom);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
