using System;
using System.Collections.Generic;
using BookStore.Application.AppServices.Contracts;
using BookStore.Domain.Account.Interfaces.Services;

namespace BookStore.Application.AppServices
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _service;

        public AppServiceBase(IServiceBase<TEntity> service)
        {
            this._service = service;
        }

        public void Add(TEntity entity)
        {
            _service.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _service.Delete(entity);
        }

        public void Edit(TEntity entity)
        {
            _service.Edit(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        public TEntity GetById(Guid id)
        {
            return _service.GetById(id);
        }

        public void Save()
        {
            _service.Save();
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}