using System;
using BookStore.Domain.Account.Entities;

namespace BookStore.Domain.Account.Interfaces.Services
{
    public interface IUserService : IDisposable, IServiceBase<User>
    {
        
    }
}