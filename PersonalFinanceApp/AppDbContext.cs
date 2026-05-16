using System.Transactions;
using Microsoft.EntityFrameworkCore;

namespace PersonalFinanceApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer("Server=.;Database=FinanceApp;Trusted_Connection=True;");
        }
    }
}
