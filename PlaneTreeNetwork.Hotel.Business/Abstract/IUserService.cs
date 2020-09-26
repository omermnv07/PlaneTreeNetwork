using PlaneTreeNetwork.Hotel.Entities.ComplexTypes;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Business.Abstract
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        User GetByUserNameAndPassword(string UserName, string Password);

        [OperationContract]
        List<UserRoleItem> GetUserRoles(User user);

        [OperationContract]
        User Add(User customer);

        [OperationContract]
        User Update(User customer);

        [OperationContract]
        List<User> GetAll();

        [OperationContract]
        User GetById(int id);
    }
}
