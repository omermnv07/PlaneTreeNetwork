using PlaneTreeNetwork.Core.DataAccess.EntityFramework;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework
{
    public class EfOtelDal : EfEntityRepositoryBase<Otel, HotelContext>, IOtelDal
    {

    }
}
