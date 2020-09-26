using PlaneTreeNetwork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Entities.Concrete
{
    public class User : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string UserPassword { get; set; }
        public virtual string UserFirstName { get; set; }
        public virtual string UserLastName { get; set; }
        public virtual string UserEmail { get; set; }
        public virtual bool UserContratStatus { get; set; }

    }
}
