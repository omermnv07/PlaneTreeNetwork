using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable(@"Users",@"dbo");
            HasKey(x => x.Id);

            Property(x => x.UserName).HasColumnName("UserName");
            Property(x => x.UserPassword).HasColumnName("UserPassword");
            Property(x => x.UserEmail).HasColumnName("UserEmail");
            Property(x => x.UserFirstName).HasColumnName("UserFirstName");
            Property(x => x.UserLastName).HasColumnName("UserLastName");
            Property(x => x.UserContratStatus).HasColumnName("UserContratStatus");
        }
    }
}
