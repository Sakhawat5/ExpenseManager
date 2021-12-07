using ExpenseTrackerWebApp.Data;
using ExpenseTrackerWebApp.Data.Models;
using ExpenseTrackerWebApp.Framework.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Framework.Service
{
    public class ExpenseReportService : IExpenseReportService
    {
        private readonly IExpenseUnitOfWork _expenseUnitOfWork;
        private readonly ExpenseDBContext _context;
        public ExpenseReportService(IExpenseUnitOfWork expenseUnitOfWork, ExpenseDBContext context)
        {
            _expenseUnitOfWork = expenseUnitOfWork;
            _context = context;
        }

        public IEnumerable<ExpenseReport> GetAllExpenses()
        {
            try
            {
                return _expenseUnitOfWork.ExpenseReportRepository.Get().ToList();
            }
            catch
            {
                throw;
            }
        }

        // To filter out the records based on the search string 
        public IEnumerable<ExpenseReport> GetSearchResult(string searchString)
        {
            List<ExpenseReport> exp = new List<ExpenseReport>();
            try
            {
                exp = GetAllExpenses().ToList();
                //return exp.Where(x => x.ItemName.Contains(searchString)).ToList();
                return exp.Where(x => x.ItemName.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) != -1);
            }
            catch
            {
                throw;
            }
        }

        //To Add new Expense record       
        public void AddExpense(ExpenseReport expense)
        {
            try
            {
                //_expenseUnitOfWork.ExpenseTrackerReportRepository.Add(expense);
                _context.ExpenseReports.Add(expense);
                _expenseUnitOfWork.Save();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar expense  
        public int UpdateExpense(ExpenseReport expense)
        {
            try
            {
                _context.ExpenseReports.Update(expense);
                //_expenseUnitOfWork.ExpenseTrackerReportRepository.Edit(expense);
                //db.Entry(expense).State = EntityState.Modified;
                _expenseUnitOfWork.Save();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the data for a particular expense  
        public ExpenseReport GetExpenseData(int id)
        {
            try
            {
                var expense = _context.ExpenseReports.FirstOrDefault(x => x.ItemId == id);
                //ExpenseReport expense = _expenseUnitOfWork.ExpenseTrackerReportRepository.GetById(id);
                return expense;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular expense  
        public void DeleteExpense(int id)
        {
            try
            {
                var expense = GetExpenseData(id);
                //ExpenseReport emp = _expenseUnitOfWork.ExpenseTrackerReportRepository.GetById(id);
                _expenseUnitOfWork.ExpenseReportRepository.Remove(expense);
                _expenseUnitOfWork.Save();

            }
            catch
            {
                throw;
            }
        }
    }
}
