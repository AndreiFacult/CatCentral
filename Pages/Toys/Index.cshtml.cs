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
    public class IndexModel : PageModel
    {
        private readonly CatCentral.Data.CatCentralContext _context;

        public IndexModel(CatCentral.Data.CatCentralContext context)
        {
            _context = context;
        }

        public IList<Toy> Toy { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Toy = await _context.Toy.ToListAsync();
        }
    }
}
