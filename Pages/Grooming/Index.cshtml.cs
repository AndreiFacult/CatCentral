using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CatCentral.Data;
using CatCentral.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CatCentral.Pages.Grooming
{
    public class IndexModel : PageModel
    {
        private readonly CatCentralContext _context;

        public IndexModel(CatCentralContext context)
        {
            _context = context;
        }

        public IList<Groom> Groom { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchField { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? SearchDate { get; set; }

        public async Task OnGetAsync()
        {
            var query = _context.Grooming
                .Include(b => b.Gallerys)
                .Include(b => b.Food)
                .Include(b => b.Toy)
                .AsQueryable();

            if (!string.IsNullOrEmpty(SearchString))
            {
                switch (SearchField)
                {
                    case "Name":
                        query = query.Where(g => g.Gallerys.Name.Contains(SearchString));
                        break;
                    case "Owner":
                        query = query.Where(g => g.Owner.Contains(SearchString));
                        break;
                }
            }

            if (SearchDate.HasValue)
            {
                query = query.Where(g => g.Date.Date == SearchDate.Value.Date);
            }

            Groom = await query.ToListAsync();
        }
    }
}
