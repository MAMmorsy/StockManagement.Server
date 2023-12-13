using FluentValidation;
using StockManagement.Server.CORE.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Server.SERVICES.Validators
{
    public class SelectStockValidator : AbstractValidator<StockSelectDto>
    {
        public SelectStockValidator()
        {
            RuleFor(m => m)
                   .NotNull().WithMessage("Invalid data");

            RuleFor(m => m.StockId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Please enter Stock Id, and try again")
                .NotNull().WithMessage("Please enter Stock Id, and try again")
                .Must(value => value != 0).WithMessage("Invalid Stock Id");
        }
    }
}
