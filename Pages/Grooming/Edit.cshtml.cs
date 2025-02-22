using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CatCentral.Data;
using CatCentral.Models;

namespace CatCentral.Pages.Grooming
{
    public class EditModel : PageModel
    {
        private readonly CatCentral.Data.CatCentralContext _context;

        public EditModel(CatCentral.Data.CatCentralContext context)
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

            var groom =  await _context.Grooming.FirstOrDefaultAsync(m => m.ID == id);
            if (groom == null)
            {
                return NotFound();
            }
            Groom = groom;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Groom).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroomExists(Groom.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GroomExists(int id)
        {
            return _context.Grooming.Any(e => e.ID == id);
        }
    }
}
