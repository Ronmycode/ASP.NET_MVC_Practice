using MVC_Project.Models;

namespace MVC_Project.Data.Services
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAll();
        Task Add(Expense expense);

        IQueryable GetChartData();
    }
}
