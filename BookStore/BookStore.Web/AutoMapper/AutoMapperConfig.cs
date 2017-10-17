using AutoMapper;

namespace BookStore.Web.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(p =>
            {
                p.AddProfile<DomainToViewModelMappingProfile>();
                p.AddProfile<ViewModelToDomainMappingProfile>();
            });

        }
    }
}