using Microsoft.EntityFrameworkCore;
using SMARTECOMM.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SMARTECOMM.Repository.Interface
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext _context;

        public UnitOfWork(DataBaseContext context)
        {
            _context = context;
        }
        public IEnumerable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>().AsQueryable();
        }

        public T Get<T>(int id) where T : class
        {
            return _context.Find<T>(id);
        }

        public T Get<T>(T model) where T : class
        {
            return _context.Find<T>(model);
        }
        private DbSet<T> DbSet<T>() where T : class
        {
            return _context.Set<T>();

        }
        //public IQueryable<T> GetWithRawSqls<T>(string query, params object[] parameters) where T : class
        //{
        //    var data= DbSet<T>().FromSql(query, parameters).AsQueryable();
        //}
        public void Save<T>(T model) where T : class
        {
            var transaction = _context.Database;
            try
            {
                transaction.BeginTransaction();
                DbSet<T>().Add(model);
                _context.Add(model);
                _context.SaveChanges();
                transaction.CommitTransaction();
            }
            catch (Exception)
            {
                transaction.RollbackTransaction();
            }
        }

        public void Update<T>(T entityToUpdate) where T : class
        {
            _context.Update<T>(entityToUpdate);
            _context.SaveChanges();
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public void Delete<T>(T id) where T : class
        {
            if (_context.Entry(id).State == EntityState.Detached)
            {
                _context.Remove<T>(id);
            }
        }

        public void AddRangeAsync<T>(IEnumerable<T> entities) where T : class
        {
            _context.Set<T>().AddRange(entities);
        }
        public void AddRangeAsync<T>(IEnumerable<T> entities, CancellationToken cancellationToken = default) where T : class
        {
            _context.Set<T>().AddRangeAsync(entities);
        }
        public void RemoveRange<T>(IEnumerable<T> entities) where T : class
        {
            _context.Set<T>().RemoveRange(entities);
        }
        //public void Delete<T>(T id) where T : class
        //{
        //    if (_context.Entry(id).State == EntityState.Detached)
        //    {
        //        _context.Remove<T>(id);
        //    }
        //}

    }
}