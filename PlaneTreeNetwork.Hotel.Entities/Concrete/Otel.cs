using PlaneTreeNetwork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Entities.Concrete
{
    public class Otel : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string OtelName { get; set; }
        public virtual string OtelCity { get; set; }
        public virtual string OtelAddress { get; set; }
        public virtual int UserId { get; set; }
    }
}
