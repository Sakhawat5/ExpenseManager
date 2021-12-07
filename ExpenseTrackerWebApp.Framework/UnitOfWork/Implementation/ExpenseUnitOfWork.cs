using ExpenseTrackerWebApp.Data;
using ExpenseTrackerWebApp.Data.UnitOfWork;
using ExpenseTrackerWebApp.Framework.Repository.Implementation;
using ExpenseTrackerWebApp.Framework.Repository.Interface;
using ExpenseTrackerWebApp.Framework.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Framework.UnitOfWork.Implementation
{
    public class ExpenseUnitOfWork : UnitOfWork<ExpenseDBContext>, IExpenseUnitOfWork
    {
        private readonly ExpenseDBContext _context;
        public ExpenseUnitOfWork(ExpenseDBContext context)
            : base(context)
        {
            _context = context;
            ExpenseReportRepository = new ExpenseReportRepository(_context);
        }
        public IExpenseReportRepository ExpenseReportRepository { get; set; }
        public IExpenseCategoryRepository ExpenseCategoryRepository { get; set; }
    }
}
