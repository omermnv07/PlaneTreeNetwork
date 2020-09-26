using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Entities.ComplexTypes
{
   public class RoomsDetail
    {
        public virtual int RoomId { get; set; }
        public virtual string OtelName { get; set; }
        public virtual string RoomName { get; set; }
    }
}
