using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ExpenseTrackerWebApp.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        //void Add(T entity);
        //void Edit(T entityToUpdate);
        //IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool isTrackingOff = false);
        //IEnumerable<T> Get(out int total, out int totalDisplay, Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);
        //T GetById(int id);
        //int GetCount(Expression<Func<T, bool>> filter = null);
        //void Remove(Expression<Func<T, bool>> filter);
        //void Remove(int id);
        //void Remove(T entityToDelete);
        void Add(T entity);
        void AddRange(IEnumerable<T> entitiesToUpdate);
        void RemoveRange(IEnumerable<T> entitiesToRemove);
        void Edit(T entityToUpdate);
        void EditRange(IEnumerable<T> enitiesToUpdate);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool isTrackingOff = false);
        IEnumerable<T> Get(out int total, out int totalDisplay, Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);
        T GetById(int id);
        T GetById(Guid id);

        int GetCount(Expression<Func<T, bool>> filter = null);
        void Remove(Expression<Func<T, bool>> filter);
        void Remove(int id);
        void Remove(T entityToDelete);
    }
}
