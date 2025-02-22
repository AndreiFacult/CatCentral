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
    public class DetailsModel : PageModel
    {
        private readonly CatCentral.Data.CatCentralContext _context;

        public DetailsModel(CatCentral.Data.CatCentralContext context)
        {
            _context = context;
        }

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
    }
}
