using FluentNHibernate.Mapping;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate.Mappings
{
    public class RoleMap : ClassMap<Role>
    {
        public RoleMap()
        {
            Table(@"Roles");
            LazyLoad();

            Id(x => x.RoleID).Column("RoleID");
            Map(x => x.RoleName).Column("RoleName");
        }
    }
}
