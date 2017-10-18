using BookStore.Application.AppServices.Interfaces;
using BookStore.Domain.Account.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace BookStore.Application.AppServices
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
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

        public TEntity GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Save()
        {
            _service.Save();
        }
    }
}