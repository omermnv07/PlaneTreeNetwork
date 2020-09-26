using Ninject.Modules;
using PlaneTreeNetwork.Core.Utilities.Common;
using PlaneTreeNetwork.Hotel.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Business.DependencyResolvers.Ninject
{
    public class ServiceModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().ToConstant(WcfProxy<ICustomerService>.CreatChannel());
            Bind<IRoomService>().ToConstant(WcfProxy<IRoomService>.CreatChannel());
        }
    }
}
