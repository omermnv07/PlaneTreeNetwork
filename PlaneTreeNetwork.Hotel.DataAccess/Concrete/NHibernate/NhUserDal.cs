using PlaneTreeNetwork.Core.DataAccess.NHihabernate;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.Entities.ComplexTypes;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate
{
    public class NhUserDal : NhEntityRepositoryBase<User>, IUserDal
    {
        public NhUserDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {

        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            throw new NotImplementedException();
        }
    }
}
