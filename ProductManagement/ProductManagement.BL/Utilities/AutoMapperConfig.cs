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
                cfg.CreateMap<CreateOptionDto, Option>().ForMember(dest => dest.CreatedDate,
                                                                    opt => opt.MapFrom(src => DateTime.Now));

                // Automatapper configuration for the create PRODUCT.
                cfg.CreateMap<CreateProductDto, Product>().ForMember(dest => dest.CreatedDate,
                                                                      opt => opt.MapFrom(src => DateTime.Now));

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
