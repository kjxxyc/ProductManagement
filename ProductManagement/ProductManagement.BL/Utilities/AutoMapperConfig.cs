using AutoMapper;
using ProductManagement.BL.DTOs;
using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.Utilities
{
    public static class AutoMapperConfig 
    {
        public static IMapper Inicialize()
        {
            
            var config = new MapperConfiguration(cfg =>
            {
                // Automatapper configuration for the create USER.
                cfg.CreateMap<CreateUserDto, User>().ForMember( dest => dest.CreatedDate,
                                                                opt => opt.MapFrom(src => DateTime.Now));

                cfg.CreateMap<User, ReadUserDto>().ForMember(dest => dest.Status,
                                                              opt => opt.MapFrom(src => src.Status == "AC" ? "Activo" : "Inactivo"));

                cfg.CreateMap<UpdateUserDto, User>();

                // Automatapper configuration for the create OPTION.
                cfg.CreateMap<CreateOrUpdateOptionDto, Option>()
                   .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.Id > 0 ? src.CreatedDate : DateTime.Now))
                   .ForMember(dest => dest.CreatedUserId, opt => opt.MapFrom(src => src.Id > 0 ? src.Id : 1));

                cfg.CreateMap<Option, ReadOptionDto>().ForMember(dest => dest.ProductName,
                                                                  opt => opt.MapFrom(src => src.Product.ProductName))
                                                      .ForMember(dest => dest.CreatedDate,
                                                                 opt => opt.MapFrom(src => src.CreatedDate.ToString("dd/MM/yyyy - hh:mm tt")));  

                // Automatapper configuration for the create PRODUCT.
                cfg.CreateMap<CreateProductDto, Product>().ForMember(dest => dest.CreatedDate,
                                                                      opt => opt.MapFrom(src => DateTime.Now));

                cfg.CreateMap<UpdateProductDto, Product>();

                cfg.CreateMap<Product, ReadProductDto>().ForMember(dest => dest.Status,
                                                                    opt => opt.MapFrom(src => src.Status == "AC" ? "Activo" : "Inactivo"));

                // Automatapper configuration for the create SUPPLIER.
                cfg.CreateMap<CreateSupplierDto, Supplier>().ForMember(dest => dest.CreatedDate,
                                                                        opt => opt.MapFrom(src => DateTime.Now));

                cfg.CreateMap<Supplier, ReadSupplierDto>();
            });

            return config.CreateMapper();
        }

    }
}
