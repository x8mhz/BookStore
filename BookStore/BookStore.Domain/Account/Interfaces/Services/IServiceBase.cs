﻿using System.Collections.Generic;

namespace BookStore.Domain.Account.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Edit(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }
}