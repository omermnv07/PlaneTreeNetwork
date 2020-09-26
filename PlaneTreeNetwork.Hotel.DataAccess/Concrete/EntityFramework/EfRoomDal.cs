using PlaneTreeNetwork.Core.DataAccess.EntityFramework;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.Entities.ComplexTypes;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework
{
    public class EfRoomDal : EfEntityRepositoryBase<Room, HotelContext>, IRoomDal
    {
        public List<RoomsDetail> GetRoomsDetails()
        {
            using (HotelContext context = new HotelContext())
            {
                var result = from r in context.Rooms
                             join o in context.Otels
                             on r.OtelId equals o.Id
                             select new RoomsDetail {
                                 OtelName = o.OtelName,
                                 RoomId = r.Id,
                                 RoomName = r.RoomName
                             };
                return result.ToList();
            }
        }
    }
}
