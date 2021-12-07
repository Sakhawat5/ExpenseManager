using ExpenseTrackerWebApp.Data;
using ExpenseTrackerWebApp.Data.Models;
using ExpenseTrackerWebApp.Framework.Service.Interface;
using ExpenseTrackerWebApp.Framework.UnitOfWork.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Framework.Service.Implementation
{
    public class ExpenseCategoryService : IExpenseCategoryService
    {
        private readonly IExpenseUnitOfWork _expenseUnitOfWork;
        private readonly ExpenseDBContext _context;
        public ExpenseCategoryService(IExpenseUnitOfWork expenseUnitOfWork, ExpenseDBContext context)
        {
            _expenseUnitOfWork = expenseUnitOfWork;
            _context = context;
        }

        public bool AddExpenseCategory(ExpenseCategory expenseCategory)
        {
            if (!IsCategoryExist(expenseCategory.Category)) { 
                //_expenseUnitOfWork.ExpenseCategoryRepository.Add(expenseCategory);
                _context.ExpenseCategories.Add(expenseCategory);
                _expenseUnitOfWork.Save();
                return true;
            }
            return false;
        }
        public bool IsCategoryExist(string categoryName)
        {
           return _context.ExpenseCategories.Any(x=>x.Category==categoryName);
        }
        public bool DeleteExpense(int id)
        {
            var expenseCategory = GetExpenseCategoryById(id);
            _expenseUnitOfWork.ExpenseCategoryRepository.Remove(expenseCategory);
            //_context.Remove(expenseCategory);
            _expenseUnitOfWork.Save();
            return true;
        }

        public List<ExpenseCategory> GetAllExpenseCategory()
        {
            //List<ExpenseCategory> expenseCategories = _expenseUnitOfWork.ExpenseCategoryRepository.Get().ToList();
            List<ExpenseCategory> expenseCategories = _context.ExpenseCategories.ToList();
            return expenseCategories;
        }

        public ExpenseCategory GetExpenseCategoryById(int id)
        {
            //return _expenseUnitOfWork.ExpenseCategoryRepository.GetById(id);
            return _context.ExpenseCategories.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateExpenseCategory(ExpenseCategory expenseCategory)
        {
            //_expenseUnitOfWork.ExpenseCategoryRepository.Edit(expenseCategory);
            _context.ExpenseCategories.Update(expenseCategory);
            _expenseUnitOfWork.Save();
            return true;
        }
    }
}
