using PlaneTreeNetwork.Core.DataAccess.EntityFramework;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.Entities.ComplexTypes;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, HotelContext>, IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (HotelContext context = new HotelContext())
            {
                var result = from ur in context.UserRoles
                             join r in context.Roles
                             on ur.UserID equals user.Id
                             where ur.UserID == user.Id
                             select new UserRoleItem { RoleName = r.RoleName };
                return result.ToList();
            }
        }
    }
}
