
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ExpenseTrackerWebApp.Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        //protected DbContext _dbContext;
        //protected DbSet<T> _dbSet;

        //public Repository(DbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //    _dbSet = _dbContext.Set<T>();
        //}

        //public virtual void Add(T entity) => _dbSet.Add(entity);

        //public virtual void Edit(T entityToUpdate)
        //{
        //    _dbSet.Attach(entityToUpdate);
        //    _dbContext.Entry(entityToUpdate).State = EntityState.Modified;
        //}

        //public virtual IEnumerable<T> Get(
        //    out int total, out int totalDisplay,
        //    Expression<Func<T, bool>> filter = null,
        //    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //    string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        //{
        //    var query = _dbSet.AsQueryable();
        //    total = query.Count();
        //    totalDisplay = total;

        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //        totalDisplay = query.Count();
        //    }

        //    foreach (var includeProperty in includeProperties.Split
        //        (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //    {
        //        query = query.Include(includeProperty);
        //    }

        //    IQueryable<T> result = null;

        //    if (orderBy != null)
        //    {
        //        result = orderBy(query).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        //    }
        //    else
        //    {
        //        result = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        //    }

        //    if (isTrackingOff)
        //        return result?.AsNoTracking().ToList();
        //    else
        //        return result?.ToList();
        //}

        //public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
        //    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //    string includeProperties = "", bool isTrackingOff = false)
        //{
        //    var query = _dbSet.AsQueryable();

        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }

        //    foreach (var includeProperty in includeProperties.Split
        //        (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //    {
        //        query = query.Include(includeProperty);
        //    }

        //    IQueryable<T> result = query;

        //    if (orderBy != null)
        //        result = orderBy(query);

        //    if (isTrackingOff)
        //        return result?.AsNoTracking().ToList();
        //    else
        //        return result?.ToList();
        //}

        //public virtual T GetById(int id)
        //{
        //    return _dbSet.Find(id);
        //}

        //public virtual int GetCount(Expression<Func<T, bool>> filter = null)
        //{
        //    var query = _dbSet.AsQueryable();

        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }

        //    return query.Count();
        //}

        //public virtual void Remove(int id)
        //{
        //    var entityToDelete = _dbSet.Find(id);
        //    Remove(entityToDelete);
        //}

        //public virtual void Remove(T entityToDelete)
        //{
        //    if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
        //    {
        //        _dbSet.Attach(entityToDelete);
        //    }
        //    _dbSet.Remove(entityToDelete);
        //}

        //public virtual void Remove(Expression<Func<T, bool>> filter) => _dbSet.RemoveRange(_dbSet.Where(filter));
        protected DbContext _dbContext;
        protected DbSet<T> _dbSet;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();

        }

        public virtual void Add(T entity)
        {
            try
            {
                _dbContext.Add(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual void AddRange(IEnumerable<T> entitiesToUpdate)
        {
            try
            {
                _dbContext.AddRange(entitiesToUpdate);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual void RemoveRange(IEnumerable<T> entitiesToRemove)
        {
            try
            {
                _dbSet.AttachRange(entitiesToRemove);
                _dbContext.RemoveRange(entitiesToRemove);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual void Edit(T entityToUpdate)
        {
            try
            {
                _dbSet.Attach(entityToUpdate);
                _dbContext.Entry(entityToUpdate).State = EntityState.Modified;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual void EditRange(IEnumerable<T> entitiesToUpdate)
        {
            try
            {
                _dbSet.AttachRange(entitiesToUpdate);
                _dbContext.Entry(entitiesToUpdate).State = EntityState.Modified;

            }


            catch (Exception ex)
            {
                throw ex;
            }
        }


        public virtual IEnumerable<T> Get(
            out int total, out int totalDisplay,
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            try
            {
                var query = _dbSet.AsQueryable();
                total = query.Count();
                totalDisplay = total;

                if (filter != null)
                {
                    query = query.Where(filter);
                    totalDisplay = query.Count();
                }

                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }

                IQueryable<T> result = null;

                if (orderBy != null)
                {
                    result = orderBy(query).Skip((pageIndex - 1) * pageSize).Take(pageSize);
                }
                else
                {
                    result = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
                }

                if (isTrackingOff)
                    return result?.AsNoTracking().ToList();
                else
                    return result?.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "", bool isTrackingOff = false)
        {
            try
            {
                var query = _dbSet.AsQueryable();

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }

                IQueryable<T> result = query;

                if (orderBy != null)
                    result = orderBy(query);

                if (isTrackingOff)
                    return result?.AsNoTracking().ToList();
                else
                    return result?.ToList();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public virtual T GetById(int id)
        {
            try
            {


                return _dbSet.Find(id);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public virtual T GetById(string id)
        {
            try
            {
                return _dbSet.Find(id);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual int GetCount(Expression<Func<T, bool>> filter = null)
        {
            try
            {
                var query = _dbSet.AsQueryable();

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return query.Count();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Remove(int id)
        {
            try
            {
                var entityToDelete = _dbSet.Find(id);
                Remove(entityToDelete);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Remove(T entityToDelete)
        {
            try
            {
                if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
                {
                    _dbSet.Attach(entityToDelete);
                }
                _dbSet.Remove(entityToDelete);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Remove(Expression<Func<T, bool>> filter)
        {
            try
            {
                _dbSet.RemoveRange(_dbSet.Where(filter));
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual T GetById(Guid id)
        {
            try
            {
                return _dbSet.Find(id);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
