using FluentNHibernate.Mapping;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate.Mappings
{
   public class UserRoleMap : ClassMap<UserRole>
    {
        public UserRoleMap()
        {
            Table(@"UserRoles");
            LazyLoad();

            Id(x => x.UserRoleID).Column("UserRoleID");
            Map(x => x.UserID).Column("UserID");
            Map(x => x.RoleID).Column("RoleID");
        }
    }
}
