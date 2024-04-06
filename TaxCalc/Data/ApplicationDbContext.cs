using Microsoft.EntityFrameworkCore;
using TaxCalc.Models;

namespace TaxCalc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<TaxViewModel> TaxIds { get; set; }
    }
}
