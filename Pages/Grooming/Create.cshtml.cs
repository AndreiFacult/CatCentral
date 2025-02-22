using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CatCentral.Data;
using CatCentral.Models;

namespace CatCentral.Pages.Grooming
{
    public class CreateModel : PageModel
    {
        private readonly CatCentral.Data.CatCentralContext _context;

        public CreateModel(CatCentral.Data.CatCentralContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Groom Groom { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Grooming.Add(Groom);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
