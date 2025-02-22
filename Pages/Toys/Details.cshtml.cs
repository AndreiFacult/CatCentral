using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CatCentral.Data;
using CatCentral.Models;

namespace CatCentral.Pages.Toys
{
    public class DetailsModel : PageModel
    {
        private readonly CatCentral.Data.CatCentralContext _context;

        public DetailsModel(CatCentral.Data.CatCentralContext context)
        {
            _context = context;
        }

        public Toy Toy { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toy = await _context.Toy.FirstOrDefaultAsync(m => m.ID == id);
            if (toy == null)
            {
                return NotFound();
            }
            else
            {
                Toy = toy;
            }
            return Page();
        }
    }
}
