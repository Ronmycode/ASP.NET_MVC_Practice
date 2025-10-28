using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;

namespace MVC_Project.Data
{
    public class Finance_Context : DbContext
    {
        public Finance_Context(DbContextOptions<Finance_Context> options) : base(options)
        {

            
        }
        public DbSet<Expense> Expenses { get; set; }

    }
}
