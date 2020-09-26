using PlaneTreeNetwork.Core.DataAccess;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Abstract
{
    public interface IOtelDal : IEntityRepository<Otel>
    {
    }
}
