using FluentValidation;
using ProductManagement.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.Validators
{
    public class CreateOptionValidator : AbstractValidator<CreateOrUpdateOptionDto>
    {
        /// <summary>
        /// Business Logic validations for Option.
        /// </summary>
        public CreateOptionValidator() 
        {
            RuleFor(x => x.OptionName).NotNull().WithMessage("El Nombre de la Opción es Requerido.")
                                      .NotEmpty().WithMessage("El Nombre de la Opción no puede estar vacio.")
                                      .MaximumLength(50).WithMessage("El Nombre de la Opción tiene una longitud máxima de 50 caracteres.");

        }
    }
}
