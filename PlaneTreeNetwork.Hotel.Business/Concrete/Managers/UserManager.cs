using PlaneTreeNetwork.Core.Aspects.Postsharp.ValidationAspects;
using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.Business.ValidationRules.FluentValidation;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.Entities.ComplexTypes;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [FluentValidationAspect(typeof(UserValidatior))]
        public User Add(User customer)
        {
            return _userDal.Add(customer);
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName && u.UserPassword == password);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }

        public User Update(User customer)
        {
            throw new NotImplementedException();
        }
    }
}
