using System;
using System.Collections.Generic;
using System.Data.Entity;
using BookStore.Domain.Account.Interfaces.Repositories;
using BookStore.Infra.Data.Context;

namespace BookStore.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private BookStoreContext _db;

        public void Dispose()
        {
            _db.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _db.Set<TEntity>();
        }

        public TEntity GetById(Guid id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
        }

        public void Edit(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}