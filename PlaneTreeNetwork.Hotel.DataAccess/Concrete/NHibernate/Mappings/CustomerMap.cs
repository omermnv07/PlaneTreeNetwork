using FluentNHibernate.Mapping;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate.Mappings
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Table(@"Customers");
            LazyLoad();

            Id(x => x.CustomerId).Column("CustomerID");
            Map(x => x.CustomerName).Column("CustomerName");
            Map(x => x.CustomerLastName).Column("CustomerLastName");
            //Map(x => x.CustomerGender).Column("CustomerGender");
            Map(x => x.CustomerYearOfBirth).Column("CustomerYearOfBirth");
            Map(x => x.UserId).Column("UserID");
            //Map(x => x.CompanyId).Column("CompanyId");
        }
    }
}
