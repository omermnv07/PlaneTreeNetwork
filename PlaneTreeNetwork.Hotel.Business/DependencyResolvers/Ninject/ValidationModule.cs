using FluentValidation;
using Ninject.Modules;
using PlaneTreeNetwork.Hotel.Business.ValidationRules.FluentValidation;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Business.DependencyResolvers.Ninject
{
   public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Customer>>().To<CustomerValidatior>().InSingletonScope();
        }
    }
}
