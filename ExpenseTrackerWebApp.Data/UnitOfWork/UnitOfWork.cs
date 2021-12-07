
using ExpenseTrackerWebApp.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTrackerWebApp.Data
{
    public class UnitOfWork<T>: IUnitOfWork<T> where T : DbContext
    {
        protected readonly DbContext _dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Dispose() => _dbContext.Dispose();

        public void Save() => _dbContext.SaveChanges();
    }
}
