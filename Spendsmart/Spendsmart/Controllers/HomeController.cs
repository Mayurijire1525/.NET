using Microsoft.AspNetCore.Mvc;
using Spendsmart.Models;
using System.Diagnostics;

namespace Spendsmart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly SpendSmartDbContext _context;
        public HomeController(ILogger<HomeController> logger,SpendSmartDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Expenses()
        {
            var allExpenses = _context.expenses.ToList();

            var totalExpenses = allExpenses.Sum(x => x.Value);
            ViewBag.Expenses = totalExpenses;
            return View(allExpenses);
        }
        public IActionResult CreateEditExpense(int? id)
        {
            if (id != null)
            {
                //editing ->load expense by id
                var expenseIndb = _context.expenses.SingleOrDefault(expense => expense.Id == id);
                return View(expenseIndb);
            }

            return View();

        }
        public IActionResult DeleteExpense(int id)
        {
            var expenseIndb=_context.expenses.SingleOrDefault(expense=> expense.Id == id);
            _context.expenses.Remove(expenseIndb);
            _context.SaveChanges();
            return RedirectToAction("Expenses");
        }
        public IActionResult CreateEditExpenseForm(Expense model)
        {
            if (model.Id ==0)
            {
                //create
                _context.expenses.Add(model);
            }
            else
            {
                //editing
                _context.expenses.Update(model);
            }


           
            _context.SaveChanges();


            return RedirectToAction("Expenses");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
