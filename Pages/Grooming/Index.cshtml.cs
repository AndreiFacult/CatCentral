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
    public class IndexModel : PageModel
    {
        private readonly CatCentral.Data.CatCentralContext _context;

        public IndexModel(CatCentral.Data.CatCentralContext context)
        {
            _context = context;
        }

        public IList<Groom> Groom { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Groom = await _context.Grooming.ToListAsync();
        }
    }
}
