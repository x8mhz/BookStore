using BookStore.Domain.Account.Entities;
using BookStore.Web.ViewModel;
using AutoMapper;
namespace BookStore.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "ViewModelToDomainMappings";

        public DomainToViewModelMappingProfile() => CreateMap<UserViewModel, User>();
    }
}