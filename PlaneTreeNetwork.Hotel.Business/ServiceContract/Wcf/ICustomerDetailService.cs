using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Business.ServiceContract.Wcf
{
    public interface ICustomerDetailService
    {
        [OperationContract]
        List<Customer> GetAll();
    }
}
