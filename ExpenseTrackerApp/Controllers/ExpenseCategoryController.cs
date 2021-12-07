using ExpenseTrackerWebApp.Data;
using ExpenseTrackerWebApp.Data.Models;
using ExpenseTrackerWebApp.Framework.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExpenseTrackerApp.Controllers
{
    public class ExpenseCategoryController : Controller
    {
        private readonly IExpenseCategoryService _expenseTrackerCategory;
        private readonly ExpenseDBContext _context;
        public ExpenseCategoryController(IExpenseCategoryService expenseTrackerCategory, ExpenseDBContext context)
        {
            _expenseTrackerCategory = expenseTrackerCategory;
            _context = context;
        }
        
        [Authorize]
        // GET: ExpenseCategoryController
        public ActionResult Index()
        {
            return View(_expenseTrackerCategory.GetAllExpenseCategory());
        }

        // GET: ExpenseCategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExpenseCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExpenseCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ExpenseCategory expenseCategory)
        {
            try
            {
                bool category = _expenseTrackerCategory.AddExpenseCategory(expenseCategory);
                if (category == true)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
            return View(expenseCategory);
        }

        // GET: ExpenseCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var category = _expenseTrackerCategory.GetExpenseCategoryById(id);
            if (category != null)
            {
                return View(category);
            }
            return View();
        }

        // POST: ExpenseCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ExpenseCategory expenseCategory)
        {
            try
            {
                bool category = _expenseTrackerCategory.UpdateExpenseCategory(expenseCategory);
                if (category == true)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
            return View(expenseCategory);
        }

        // GET: ExpenseCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = _expenseTrackerCategory.GetExpenseCategoryById(id);
            if (category != null)
            {
                return View(category);
            }
            return View();
        }

        // POST: ExpenseCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ExpenseCategory expenseCategory)
        {
            try
            {
                bool category = _expenseTrackerCategory.DeleteExpense(id);
                if(category == true)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }
            return View(expenseCategory);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult IsExist(string Category)
        {
            if (_context.ExpenseCategories.Any(x => x.Category == Category))
            {
                return Json($"A category named {Category} already exists.");
            }

            return Json(true);
        }
    }
}
