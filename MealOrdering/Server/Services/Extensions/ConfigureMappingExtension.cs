using AutoMapper;
using MealOrdering.Server.Data.Models;
using MealOrdering.Shared.DTO;
using MealOrdering.Shared.Utils;
using Microsoft.Extensions.DependencyInjection;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62

namespace MealOrdering.Server.Services.Extensions
{
    public static class ConfigureMappingExtension
    {
<<<<<<< HEAD
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

            IMapper mapper = mappingConfig.CreateMapper();

            service.AddSingleton(mapper);

            return service;
        }
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullDestinationValues = true;
            AllowNullCollections = true;

            CreateMap<Suppliers, SupplierDTO>()
                .ReverseMap();

            CreateMap<Users, UserDTO>();

            CreateMap<UserDTO, Users>()
                .ForMember(x => x.Password, y => y.MapFrom(z => PasswordEncrypter.Encrypt(z.Password)))
                ;

            CreateMap<Orders, OrderDTO>()
                .ForMember(x => x.SupplierName, y => y.MapFrom(z => z.Supplier.Name))
                .ForMember(x => x.CreatedUserFullName, y => y.MapFrom(z => z.CreatedUser.FirstName + " " + z.CreatedUser.LastName));

            CreateMap<OrderDTO, Orders>();



            CreateMap<OrderItems, OrderItemsDTO>()
                .ForMember(x => x.CreatedUserFullName, y => y.MapFrom(z => z.CreatedUser.FirstName + " " + z.CreatedUser.LastName))
                .ForMember(x => x.OrderName, y => y.MapFrom(z => z.Order.Name ?? ""));

            CreateMap<OrderItemsDTO, OrderItems>();
=======
     
            public static IServiceCollection ConfigureMapping(this IServiceCollection service)
            {
                var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

                IMapper mapper = mappingConfig.CreateMapper();

                service.AddSingleton(mapper);

                return service;
            }
        

        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                AllowNullDestinationValues = true;
                AllowNullCollections = true;

                CreateMap<Suppliers, SupplierDTO>()
                    .ReverseMap();

                CreateMap<Users, UserDTO>();

                CreateMap<UserDTO, Users>()
                    .ForMember(x => x.Password, y => y.MapFrom(z => PasswordEncryptor.Encrypt(z.Password)))
                    ;

                CreateMap<Orders, OrderDTO>()
                    .ForMember(x => x.SupplierName, y => y.MapFrom(z => z.Supplier.Name))
                    .ForMember(x => x.CreatedUserFullName, y => y.MapFrom(z => z.CreatedUser.FirstName + " " + z.CreatedUser.LastName));

                CreateMap<OrderDTO, Orders>();



                CreateMap<OrderItems, OrderItemsDTO>()
                    .ForMember(x => x.CreatedUserFullName, y => y.MapFrom(z => z.CreatedUser.FirstName + " " + z.CreatedUser.LastName))
                    .ForMember(x => x.OrderName, y => y.MapFrom(z => z.Order.Name ?? ""));

                CreateMap<OrderItemsDTO, OrderItems>();
            }
>>>>>>> 9e6b9473dcf2cd01f3c11c3d90412de78c5a2a62
        }
    }
}
