using FluentValidation;
using ProductManagement.BL.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.Validators
{
    public class CreateProductValidator : AbstractValidator<CreateProductDto>
    {
        /// <summary>
        /// Business Logic validations for Products.
        /// </summary>
        public CreateProductValidator()
        {
            RuleFor(x => x.CodeProduct).NotNull().WithMessage("El Código es Requerido.")
                                        .NotEmpty().WithMessage("El Código no puede estar vacio.")
                                        .MaximumLength(15).WithMessage("El Código tiene una longitud máxima de 15 caracteres.");

            RuleFor(x => x.ProductName).NotNull().WithMessage("El Nombre del producto es Requerido.")
                                        .NotEmpty().WithMessage("El Nombre del producto no puede estar vacio.")
                                        .MaximumLength(100).WithMessage("El Nombre del producto tiene una longitud máxima de 100 caracteres.");

            RuleFor(x => x.QuantityStock).NotNull().WithMessage("La Existencia es Requerida")
                                         .NotEmpty().WithMessage("La Existencia no puede estar vacio.")
                                         .PrecisionScale(9, 2, false).WithMessage("La Existencia debe cumplir el formato (00.00) con dos decimales");
                                         


        }
    }
}
