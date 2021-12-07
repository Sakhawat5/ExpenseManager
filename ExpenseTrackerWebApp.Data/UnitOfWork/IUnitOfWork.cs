
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;

namespace ExpenseTrackerWebApp.Data.UnitOfWork
{
    public interface IUnitOfWork<T> : IDisposable where T: DbContext
    {
        void Save();
    }
}
