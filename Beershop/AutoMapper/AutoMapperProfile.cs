using AutoMapper;

using BeerShop.ViewModels;
using BeerStore.Models.Entities;

namespace BeerShop.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<TSource, TDestination>;

            // Eerste manier
            // Brouwernaam en Soortnaam worden niet weergegeven als we onderstaande CreateMap gebruiken
            // want de property-name zijn anders. Er kan geen automatische mapping gebeuren voor deze properties
            //CreateMap<Beer, BeerVM>();

            //Tweede manier
            // We nemen zelf de mapping op.
            // Brouwernaam en Soortnaam worden niet weergegeven als we onderstaande CreateMap gebruiken
            //  want we mappen het brouwernr en soortnr
            //CreateMap<Beer, BeerVM>().ForMember(dest => dest.BrouwerNaam,
            //    opts => opts.MapFrom(
            //        src => src.Brouwernr

            //    ))
            //                    .ForMember(dest => dest.SoortNaam,
            //        opts => opts.MapFrom(
            //            src => src.Soortnr
            //        ));

            // derde manier

            CreateMap<Beer, BeerVM>().ForMember(dest => dest.BrouwerNaam,
                opts => opts.MapFrom(
                    src => src.BrouwernrNavigation.Naam

                ))
                                .ForMember(dest => dest.SoortNaam,
                    opts => opts.MapFrom(
                        src => src.SoortnrNavigation.Soortnaam
                    ));


            CreateMap<Brewery, BreweryVM>();

            // CRUD

            // Create
            CreateMap<BeerCreateVM, Beer>();
            CreateMap<Beer, BeerCreateVM>();

            CreateMap<BeerEditVM, Beer>();
            CreateMap<Beer, BeerEditVM>();

        }
    }
}
