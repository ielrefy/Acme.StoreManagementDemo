using Acme.StoreManagementDemo.DTOs.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.StoreManagementDemo.Services.Products
{
    public class CreateUpdateProductDTOValidator : AbstractValidator<CreateUpdateProductDTO>
    {
        public CreateUpdateProductDTOValidator() {
            RuleFor(a => a.Price).GreaterThan(0).WithMessage("Price should be greater than 0 !!");

        }
    }
}
