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
    public interface IRoomService
    {
        [OperationContract]
        Room Add(Room customer);

        [OperationContract]
        Room Update(Room customer);

        [OperationContract]
        List<Room> GetAll();

        [OperationContract]
        Room GetById(int id);

        [OperationContract]
        void TransactionalOperation(Room room1, Room room2);
    }
}
