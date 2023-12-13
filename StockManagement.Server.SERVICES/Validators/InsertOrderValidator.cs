using FluentValidation;
using StockManagement.Server.CORE.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.SERVICES.Validators
{
    internal class InsertOrderValidator : AbstractValidator<OrderInsertDto>
    {

       
            public InsertOrderValidator()
            {
                RuleFor(m => m)
                   .NotNull().WithMessage("Invalid data");

                RuleFor(m => m.PersonName)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("Please enter Person Name, and try again")
                    .NotNull().WithMessage("Please enter Person Name, and try again")
                    .Must(value => value != "").WithMessage("Invalid Person Name");

            RuleFor(m => m.Quantity)
        .Cascade(CascadeMode.Stop)
        .NotEmpty().WithMessage("Please enter Quantity, and try again")
                .NotNull().WithMessage("Please enter Quantity, and try again")
                .Must(value => value != 0).WithMessage("Invalid Quantity");

                RuleFor(m => m.StockId)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("Please enter Stock Id, and try again")
                    .NotNull().WithMessage("Please enter Stock Id, and try again")
                    .Must(value => value !=0).WithMessage("Invalid Stock Id");
            
                RuleFor(m => m.Price)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("Please enter Price, and try again")
                    .NotNull().WithMessage("Please enter Price, and try again")
                    .Must(value => value !=0).WithMessage("Invalid Price");

            }
        }
    }