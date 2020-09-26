using FluentNHibernate.Mapping;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate.Mappings
{
    public class RoomMap : ClassMap<Room>
    {
        public RoomMap()
        {
            Table(@"Rooms");
            LazyLoad();

            Id(x => x.Id).Column("Id");
            Map(x => x.OtelId).Column("OtelId");
            Map(x => x.RoomName).Column("RoomName");
        }
    }
}
