using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework.Mappings
{
    public class OtelMap : EntityTypeConfiguration<Otel>
    {
        public OtelMap()
        {
            ToTable(@"Otels", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.OtelName).HasColumnName("OtelName");
            Property(x => x.OtelCity).HasColumnName("OtelCity");
            Property(x => x.OtelAddress).HasColumnName("OtelAddress");
            Property(x => x.UserId).HasColumnName("UserId");


        }
    }
}
