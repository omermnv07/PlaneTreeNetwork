using PlaneTreeNetwork.Core.DataAccess.NHihabernate;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate
{
    public class NhOtelDal : NhEntityRepositoryBase<Otel>, IOtelDal
    {
        public NhOtelDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {

        }
        
    }
}
