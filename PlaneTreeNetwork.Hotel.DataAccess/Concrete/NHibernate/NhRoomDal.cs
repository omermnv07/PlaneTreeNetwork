using PlaneTreeNetwork.Core.DataAccess.NHihabernate;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.Entities.ComplexTypes;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate
{
    public class NhRoomDal : NhEntityRepositoryBase<Room>, IRoomDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhRoomDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<RoomsDetail> GetRoomsDetails()
        {
            using ( var session = _nHibernateHelper.OpenSession())
            {
                var result = from r in session.Query<Room>()
                             join o in session.Query<Otel>() 
                             on r.OtelId equals o.Id
                             select new RoomsDetail
                             {
                                OtelName= o.OtelName,
                                RoomId = r.Id,
                                RoomName=r.RoomName
                             };
                return result.ToList();
            }
        }
    }
}
