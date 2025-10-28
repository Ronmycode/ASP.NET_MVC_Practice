using Microsoft.AspNetCore.Mvc;
using MVC_Project.Data;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class ExpensesController : Controller
    {   
        private readonly Finance_Context _context;
        public ExpensesController(Finance_Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var expenses = _context.Expenses.ToList();
            return View(expenses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            if(ModelState.IsValid)
            {
                _context.Expenses.Add(expense);
                _context.SaveChanges();
                
                return RedirectToAction("Index");
            }
            return View(expense);
        }
    }
}
