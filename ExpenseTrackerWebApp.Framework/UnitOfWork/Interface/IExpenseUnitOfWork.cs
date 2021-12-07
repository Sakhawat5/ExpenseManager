
using ExpenseTrackerWebApp.Data;
using ExpenseTrackerWebApp.Data.UnitOfWork;
using ExpenseTrackerWebApp.Framework.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Framework
{
    public interface IExpenseUnitOfWork : IUnitOfWork<ExpenseDBContext>, IDisposable
    {
        IExpenseReportRepository ExpenseReportRepository { get; }
        IExpenseCategoryRepository ExpenseCategoryRepository { get; }
    }
}
