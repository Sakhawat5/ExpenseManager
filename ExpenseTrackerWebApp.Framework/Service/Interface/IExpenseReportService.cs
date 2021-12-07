using ExpenseTrackerWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Framework.Service.Interface
{
    public interface IExpenseReportService
    {
        IEnumerable<ExpenseReport> GetAllExpenses();
        IEnumerable<ExpenseReport> GetSearchResult(string searchString);
        void AddExpense(ExpenseReport expense);
        int UpdateExpense(ExpenseReport expense);
        ExpenseReport GetExpenseData(int id);
        void DeleteExpense(int id);
        //Dictionary<string, decimal> CalculateMonthlyExpense();
        //Dictionary<string, decimal> CalculateWeeklyExpense();
    }
}
