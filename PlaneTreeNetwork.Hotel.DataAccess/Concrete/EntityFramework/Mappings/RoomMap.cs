using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework.Mappings
{
   public class RoomMap: EntityTypeConfiguration<Room>
    {
        public RoomMap()
        {
            ToTable(@"Rooms", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.OtelId).HasColumnName("OtelId");
            Property(x => x.RoomName).HasColumnName("RoomName");
           
        }
    }
}
