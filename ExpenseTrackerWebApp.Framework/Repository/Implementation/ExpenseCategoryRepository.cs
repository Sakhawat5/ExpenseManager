using ExpenseTrackerWebApp.Data;
using ExpenseTrackerWebApp.Data.Models;
using ExpenseTrackerWebApp.Data.Repository;
using ExpenseTrackerWebApp.Framework.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Framework.Repository.Implementation
{
    public class ExpenseCategoryRepository : Repository<ExpenseCategory>, IExpenseCategoryRepository
    {
        public ExpenseCategoryRepository(ExpenseDBContext context)
            : base(context)
        {

        }
    }
}
