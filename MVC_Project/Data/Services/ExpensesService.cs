using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;

namespace MVC_Project.Data.Services
{
    public class ExpensesService : IExpensesService
    {
        private readonly Finance_Context _context;

        public ExpensesService(Finance_Context context)
        {
            _context = context;
        }

        public async Task Add(Expense expense)
        {
            Console.WriteLine($"Using DB: {_context.Database.GetConnectionString()}");
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Expense>> GetAll()
        {
            var expenses = await _context.Expenses.ToListAsync();
            return expenses;
        }

        public IQueryable GetChartData()
        {
            var data = _context.Expenses
                               .GroupBy(e => e.Category)
                               .Select(g => new
                               {
                                   Category = g.Key,
                                   Total = g.Sum(e => e.Amount)
                               });
            return data;
        }
    }
}
