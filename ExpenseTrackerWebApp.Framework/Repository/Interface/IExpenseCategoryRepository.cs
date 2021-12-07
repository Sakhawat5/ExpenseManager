using ExpenseTrackerWebApp.Data.Models;
using ExpenseTrackerWebApp.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Framework.Repository.Interface
{
    public interface IExpenseCategoryRepository : IRepository<ExpenseCategory>
    {
    }
}