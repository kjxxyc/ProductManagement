using FluentValidation;
using ProductManagement.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.Validators
{
    public class CreateSupplierValidator : AbstractValidator<CreateSupplierDto>
    {
        /// <summary>
        /// Business Logic validations for Supplier.
        /// </summary>
        public CreateSupplierValidator() 
        {
            RuleFor(x => x.SupplerName).NotNull().WithMessage("El Nombre del Proveedor es Requerido.")
                                       .NotEmpty().WithMessage("El Nombre del Proveedor no puede estar vacio.")
                                       .MaximumLength(100).WithMessage("El Nombre del Proveedor tiene una longitud máxima de 100 caracteres.");
        }
    }
}
