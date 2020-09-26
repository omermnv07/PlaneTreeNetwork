using FluentNHibernate.Mapping;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate.Mappings
{
    public class OtelMap : ClassMap<Otel>
    {
        public OtelMap()
        {
            Table(@"Otels");
            LazyLoad();

            Id(x => x.Id).Column("Id");
            Map(x => x.OtelName).Column("OtelName");
            Map(x => x.OtelCity).Column("OtelCity");
            Map(x => x.OtelAddress).Column("OtelAddress");
            Map(x => x.UserId).Column("UserId");

        }
    }
}
