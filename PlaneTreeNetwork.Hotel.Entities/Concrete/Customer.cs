using PlaneTreeNetwork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Entities.Concrete
{
    public class Customer : IEntity
    {
        public virtual int CustomerId { get; set; }
        public virtual string CustomerName { get; set; }
        public virtual string CustomerLastName { get; set; }
        //public virtual char CustomerGender { get; set; }
        public virtual DateTime CustomerYearOfBirth { get; set; }
        public virtual int UserId { get; set; }
       // public virtual int CompanyId { get; set; }

    }
}
