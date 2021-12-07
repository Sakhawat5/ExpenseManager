using ExpenseManager.Interfaces;
using ExpenseTrackerWebApp.Data;
using ExpenseTrackerWebApp.Data.Models;
using ExpenseTrackerWebApp.Framework.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTrackerApp.Controllers
{
    public class ExpenseTrackerReportController : Controller
    {
        private readonly IExpenseReportService _expenseTrackerReport;
        private readonly IExpenseService _context;
        private readonly IExpenseCategoryService _expenseTrackerCategory;
        public ExpenseTrackerReportController(IExpenseReportService expenseTrackerReport, IExpenseService context, IExpenseCategoryService expenseTrackerCategory)
        {
            _expenseTrackerReport = expenseTrackerReport;
            _context = context;
            _expenseTrackerCategory = expenseTrackerCategory;
        }

        [Authorize]
        // GET: ExpenseTrackerReportController
        public ActionResult Index(string searchString)
        {
            List<ExpenseReport> lstEmployee = new List<ExpenseReport>();
            lstEmployee = _expenseTrackerReport.GetAllExpenses().ToList();

            if (!string.IsNullOrEmpty(searchString))
            {
                lstEmployee = _expenseTrackerReport.GetSearchResult(searchString).ToList();
            }
            return View(lstEmployee);
        }

        public ActionResult AddEditExpenses(int itemId)
        {
            var expenseCategory = _expenseTrackerCategory.GetAllExpenseCategory();
            ViewBag.expenseCategory = new SelectList(expenseCategory, "Id", "Category");
            ExpenseReport model = new ExpenseReport();
            if (itemId > 0)
            {
                model = _expenseTrackerReport.GetExpenseData(itemId);
            }
            return PartialView("_expenseForm", model);
        }

        // POST: ExpenseTrackerReportController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ExpenseReport newExpense, int expenseCategory)
        {
            
            newExpense.ExpenseCategoryId = expenseCategory;

            if (ModelState.IsValid)
            {
                if (newExpense.ItemId > 0)
                {
                    _expenseTrackerReport.UpdateExpense(newExpense);
                }
                else
                {
                    _expenseTrackerReport.AddExpense(newExpense);
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult ExpenseSummary()
        {
            return PartialView("_expenseReport");
        }
        public JsonResult GetMonthlyExpense()
        {
            Dictionary<string, decimal> monthlyExpense = _context.CalculateMonthlyExpense();
            return new JsonResult(monthlyExpense);
        }

        public JsonResult GetWeeklyExpense()
        {
            Dictionary<string, decimal> weeklyExpense = _context.CalculateWeeklyExpense();
            return new JsonResult(weeklyExpense);
        }
        public JsonResult GetDailyExpense()
        {
            Dictionary<string, decimal> dailyExpense = _context.CalculateDailyExpense();
            return new JsonResult(dailyExpense);
        }

        // POST: ExpenseTrackerReportController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                _expenseTrackerReport.DeleteExpense(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }
    }
}
