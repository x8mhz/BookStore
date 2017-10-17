using AutoMapper;
using BookStore.Domain.Account.Entities;
using BookStore.Web.ViewModel;

namespace BookStore.Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName => "DomainToViewModelMappings";

        public ViewModelToDomainMappingProfile() => CreateMap<User, UserViewModel>();
    }
}