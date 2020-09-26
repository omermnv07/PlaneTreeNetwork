using PlaneTreeNetwork.Core.DataAccess;
using PlaneTreeNetwork.Hotel.Entities.ComplexTypes;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Abstract
{
    public interface IRoomDal : IEntityRepository<Room>
    {
        List<RoomsDetail> GetRoomsDetails();
    }
}
