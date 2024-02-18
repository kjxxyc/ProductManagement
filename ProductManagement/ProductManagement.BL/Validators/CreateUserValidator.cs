using FluentValidation;
using ProductManagement.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.Validators
{
    public class CreateUserValidator : AbstractValidator<CreateUserDto>
    {
        /// <summary>
        /// Business Logic validations for Add Users.
        /// </summary>
        public CreateUserValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("El Nombre es Requerido.")
                                .NotEmpty().WithMessage("El Nombre no puede estar vacio.")
                                .MaximumLength(50).WithMessage("El Nombre tiene una longitud máxima de 50 caracteres.");
            
            RuleFor(x => x.LastName).NotNull().WithMessage("El Apellido es Requerido.")
                                    .NotEmpty().WithMessage("El Apellido no puede estar vacio.")
                                    .MaximumLength(50).WithMessage("El Apellido tiene una longitud máxima de 50 caracteres.");

            RuleFor(x => x.UserName).NotNull().WithMessage("El Nombre de usuario es Requerido.")
                                    .NotEmpty().WithMessage("El Nombre de usuario no puede estar vacio.")
                                    .MaximumLength(15).WithMessage("El Nombre de usuario tiene una longitud máxima de 15 caracteres");

            RuleFor(x => x.Password).NotNull().WithMessage("La Contraseña es Requerida.")
                                    .NotEmpty().WithMessage("La Contraseña no puede estar vacia.")
                                    .MaximumLength(100).WithMessage("La Contraseña tiene una longitud máxima de 100 caracteres")
                                    .Equal(x => x.ConfirmPassword).WithMessage("Las contrasenas deben coincidir.");

            RuleFor(x => x.ConfirmPassword).NotNull().WithMessage("La confirmación de contraseña es Requerida.")
                                            .NotEmpty().WithMessage("La confirmación de contraseña no puede estar vacia.")
                                            .MaximumLength(100).WithMessage("La confirmación de contraseña tiene una longitud máxima de 100 caracteres");

            // Validate email field (example@mail.com)
            RuleFor(x => x.Email).EmailAddress().WithMessage("Debe usar la nomenclatura usuario@correo.com")
                                    .NotNull().WithMessage("El e-mail es Requerido.")
                                    .NotEmpty().WithMessage("El e-mail no puede estar vacio.")
                                    .MaximumLength(100).WithMessage("El e-mail tiene una longitud máxima de 100 caracteres");

            // Validate telephone field (0000-0000)
            RuleFor(x => x.Telephone).NotNull().WithMessage("El Telefono es Requerido.")
                                    .NotEmpty().WithMessage("El Telefono no puede estar vacio.")
                                    .MinimumLength(8).WithMessage("El Telefono tiene una longitud minima de 8 caracteres")
                                    .MaximumLength(8).WithMessage("El Telefono tiene una longitud máxima de 8 caracteres");

        }
    }
}
