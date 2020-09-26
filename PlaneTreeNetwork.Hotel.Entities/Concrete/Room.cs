using PlaneTreeNetwork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Entities.Concrete
{
    public class Room : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int OtelId { get; set; }
        public virtual string RoomName { get; set; }
    }
}
