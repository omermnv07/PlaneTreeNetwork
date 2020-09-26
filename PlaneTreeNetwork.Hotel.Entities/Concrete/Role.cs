using PlaneTreeNetwork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Entities.Concrete
{
   public class Role:IEntity
    {
        public virtual int RoleID { get; set; }
        public virtual string RoleName { get; set; }
    }
}
