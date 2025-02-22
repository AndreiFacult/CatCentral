using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CatCentral.Data;
using CatCentral.Models;

namespace CatCentral.Pages.Gallery
{
    public class DeleteModel : PageModel
    {
        private readonly CatCentral.Data.CatCentralContext _context;

        public DeleteModel(CatCentral.Data.CatCentralContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Gallerys Gallerys { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gallerys = await _context.Gallerys.FirstOrDefaultAsync(m => m.ID == id);

            if (gallerys == null)
            {
                return NotFound();
            }
            else
            {
                Gallerys = gallerys;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gallerys = await _context.Gallerys.FindAsync(id);
            if (gallerys != null)
            {
                Gallerys = gallerys;
                _context.Gallerys.Remove(Gallerys);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
