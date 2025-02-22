using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CatCentral.Models;

namespace CatCentral.Data
{
    public class CatCentralContext : DbContext
    {
        public CatCentralContext (DbContextOptions<CatCentralContext> options)
            : base(options)
        {
        }

        public DbSet<CatCentral.Models.Groom> Grooming { get; set; } = default!;
        public DbSet<CatCentral.Models.Food> Food { get; set; } = default!;
        public DbSet<CatCentral.Models.Toy> Toy { get; set; } = default!;
        public DbSet<CatCentral.Models.Gallerys> Gallerys { get; set; } = default!;
    }
}
