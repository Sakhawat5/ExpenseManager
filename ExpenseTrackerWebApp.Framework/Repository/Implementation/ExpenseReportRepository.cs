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
    public class ExpenseReportRepository : Repository<ExpenseReport>, IExpenseReportRepository
    {
        public ExpenseReportRepository(ExpenseDBContext context)
            : base(context)
        {

        }
    }
}
