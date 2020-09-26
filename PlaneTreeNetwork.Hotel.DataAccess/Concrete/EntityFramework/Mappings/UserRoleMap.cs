using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserRoleMap:EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            ToTable(@"UserRoles", @"dbo");
            HasKey(x => x.UserRoleID);

            Property(x => x.UserID).HasColumnName("UserID");
            Property(x => x.RoleID).HasColumnName("RoleID");
        }
    }
}
