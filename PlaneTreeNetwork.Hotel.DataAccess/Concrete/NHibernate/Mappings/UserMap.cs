using FluentNHibernate.Mapping;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table(@"Users");
            LazyLoad();

            Id(x => x.Id).Column("Id");
            Map(x => x.UserName).Column("UserName");
            Map(x => x.UserPassword).Column("UserPassword");
            Map(x => x.UserEmail).Column("UserEmail");
            Map(x => x.UserFirstName).Column("UserFirstName");
            Map(x => x.UserLastName).Column("UserLastName");
            Map(x => x.UserContratStatus).Column("UserContratStatus");
            
        }
    }
}
