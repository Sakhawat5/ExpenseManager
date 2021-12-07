using ExpenseTrackerWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Framework.Service.Interface
{
    public interface IExpenseCategoryService
    {
        List<ExpenseCategory> GetAllExpenseCategory();
        bool AddExpenseCategory(ExpenseCategory expenseCategory);
        bool UpdateExpenseCategory(ExpenseCategory expenseCategory);
        ExpenseCategory GetExpenseCategoryById(int id);
        bool DeleteExpense(int id);
    }
}
