using FluentValidation;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Business.ValidationRules.FluentValidation
{
    public class CustomerValidatior : AbstractValidator<Customer>
    {
        public CustomerValidatior()
        {
            RuleFor(x => x.CustomerId).NotEmpty();
            RuleFor(x => x.CustomerName).NotEmpty().Length(2,20);
            RuleFor(x => x.CustomerLastName).NotEmpty();
        }
    }
}
