using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable(@"Customers", @"dbo");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("CustomerID");
            Property(x => x.CustomerName).HasColumnName("CustomerName");
            Property(x => x.CustomerLastName).HasColumnName("CustomerLastName");
            //Property(x => x.CustomerGender).HasColumnName("CustomerGender");
            Property(x => x.CustomerYearOfBirth).HasColumnName("CustomerYearOfBirth");
            Property(x => x.UserId).HasColumnName("UserID");
            //Property(x => x.CompanyId).HasColumnName("CompanyId");
        }
    }
}
