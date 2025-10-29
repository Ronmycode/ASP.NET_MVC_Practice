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
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Expense>> GetAll()
        {
            var expenses = await _context.Expenses.ToListAsync();
            return expenses;
        }
    }
}
