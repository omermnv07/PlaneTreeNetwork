using FluentValidation;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Business.ValidationRules.FluentValidation
{
    public class UserValidatior: AbstractValidator<User>
    {
        public UserValidatior()
        {
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.UserPassword).NotEmpty();
            RuleFor(x => x.UserFirstName).NotEmpty();
            RuleFor(x => x.UserLastName).NotEmpty();
            RuleFor(x => x.UserEmail).NotEmpty();
            RuleFor(x => x.UserContratStatus).NotNull();
            RuleFor(x => x.UserContratStatus).NotEmpty();
        }
    }
}
