using BookStore.Domain.Account.Interfaces.Repositories;
using BookStore.Domain.Account.Interfaces.Services;
using System.Collections.Generic;

namespace BookStore.Domain.Account.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Edit(TEntity entity)
        {
            _repository.Edit(entity);
        }

        public void Delete(TEntity entity)
        {
           _repository.Delete(entity);
        }

        public void Save()
        {
            _repository.Save();
        }
    }
}