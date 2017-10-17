using BookStore.Application.AppServices.Interfaces;
using BookStore.Domain.Account.Entities;
using BookStore.Domain.Account.Interfaces.Services;

namespace BookStore.Application.AppServices
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _iUserService;

        public UserAppService(IServiceBase<User> service, IUserService iUserService) : base(service)
        {
            this._iUserService = iUserService;
        }
    }
}