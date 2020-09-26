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
    public interface ICustomerService
    {
        [OperationContract]
        Customer Add(Customer customer);

        [OperationContract]
        Customer Update(Customer customer);

        [OperationContract]
        List<Customer> GetAll();

        [OperationContract]
        Customer GetById(int id);

        [OperationContract]
        void TransactionalOperation(Customer customer1,Customer customer2);

    }
}
