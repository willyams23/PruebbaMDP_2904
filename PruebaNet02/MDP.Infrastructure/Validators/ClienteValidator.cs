using FluentValidation;
using MDP.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDP.Infrastructure.Validators
{
    public class ClienteValidator : AbstractValidator<ClienteDto>
    {
        public ClienteValidator()
        {
            RuleFor(cli => cli.Nombre)
               .NotNull()
               .WithMessage("La campo nombre no puede ser nulo");

            RuleFor(cli => cli.Nombre)
                .Length(3, 250)
                .WithMessage("La longitud del campo nombre debe estar entre 3 y 250 caracteres");


            RuleFor(cli => cli.Apellido)
               .NotNull()
               .WithMessage("La campo apellido no puede ser nulo");

            RuleFor(cli => cli.Apellido)
                .Length(3, 250)
                .WithMessage("La longitud del campo apellido debe estar entre 3 y 250 caracteres");

            RuleFor(cli => cli.Correo)
              .NotNull()
              .WithMessage("La campo correo no puede ser nulo");

            RuleFor(cli => cli.Correo)
                .EmailAddress()
                .WithMessage("La campo correo es inválido");

            //RuleFor(cli => cli.Activo)
            //    .NotNull()
            //    .LessThan(true);

            RuleFor(cli => cli.FechaRegistro)
                .NotNull()
                .WithMessage("La campo Fecha de Registro no puede ser nulo");
        }
    }
}
