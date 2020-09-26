using Ninject.Modules;
using PlaneTreeNetwork.Core.DataAccess;
using PlaneTreeNetwork.Core.DataAccess.EntityFramework;
using PlaneTreeNetwork.Core.DataAccess.NHihabernate;
using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.Business.Concrete.Managers;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework;
using PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate;
using PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Business.DependencyResolvers.Ninject
{
   public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();
            Bind<IRoomService>().To<RoomManager>().InSingletonScope();
            Bind<IRoomDal>().To<EfRoomDal>().InSingletonScope();
            Bind<IOtelDal>().To<EfOtelDal>().InSingletonScope();


            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();

            //////Standart//////
            ///
            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<HotelContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
            //////Standart//////

        


          
        }
    }
}
