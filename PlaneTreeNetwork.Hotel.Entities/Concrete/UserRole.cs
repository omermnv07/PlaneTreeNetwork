using PlaneTreeNetwork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Entities.Concrete
{
   public class UserRole:IEntity
    {
        public virtual int UserRoleID { get; set; }
        public virtual int UserID { get; set; }
        public virtual int RoleID { get; set; }
    }
}
