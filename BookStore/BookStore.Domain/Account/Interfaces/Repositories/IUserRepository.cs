using System;
using BookStore.Domain.Account.Entities;

namespace BookStore.Domain.Account.Interfaces.Repositories
{
    public interface IUserRepository : IDisposable, IRepositoryBase<User>
    {
        
    }
}