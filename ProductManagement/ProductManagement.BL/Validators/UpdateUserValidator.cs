using FluentValidation;
using ProductManagement.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.Validators
{
    public class UpdateUserValidator : AbstractValidator<UpdateUserDto>
    {

        public UpdateUserValidator() 
        {
            RuleFor(x => x.Name).NotNull().WithMessage("El Nombre es Requerido.")
                                .NotEmpty().WithMessage("El Nombre no puede estar vacio.")
                                .MaximumLength(50).WithMessage("El Nombre tiene una longitud máxima de 50 caracteres.");

            RuleFor(x => x.LastName).NotNull().WithMessage("El Apellido es Requerido.")
                                    .NotEmpty().WithMessage("El Apellido no puede estar vacio.")
                                    .MaximumLength(50).WithMessage("El Apellido tiene una longitud máxima de 50 caracteres.");

            RuleFor(x => x.Telephone).NotNull().WithMessage("El Telefono es Requerido.")
                                    .NotEmpty().WithMessage("El Telefono no puede estar vacio.")
                                    .MaximumLength(8).WithMessage("El Telefono tiene una longitud máxima de 8 caracteres");
        }
    }
}
