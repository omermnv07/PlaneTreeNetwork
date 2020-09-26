using AutoMapper;
using PlaneTreeNetwork.Core.Aspects.Postsharp.AuthorizationAspects;
using PlaneTreeNetwork.Core.Aspects.Postsharp.CacheAspects;
using PlaneTreeNetwork.Core.Aspects.Postsharp.ExceptionAspects;
using PlaneTreeNetwork.Core.Aspects.Postsharp.ValidationAspects;
using PlaneTreeNetwork.Core.CrossCuttingConcerns.Caching.Microsoft;
using PlaneTreeNetwork.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.Business.ValidationRules.FluentValidation;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.Business.Concrete.Managers
{
    public class RoomManager : IRoomService
    {
        private IRoomDal _roomDal;
        private readonly IMapper _mapper;

        public RoomManager(IRoomDal roomDal, IMapper mapper)
        {
            _roomDal = roomDal;
            _mapper = mapper;
        }

        [ExceptionLogAspect(typeof(DatabaseLogger))]
        [FluentValidationAspect(typeof(CustomerValidatior))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Room Add(Room room)
        {
           return _roomDal.Add(room);
        }

        [SecuredOperation(Roles = "Editor,Admin,Employee")] //Authorized !!!
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Room> GetAll()
        {
            var rooms = _mapper.Map<List<Room>>(_roomDal.GetList());//AutoMapperHelper.MapToSameTypeList(_customerDal.GetList());
            return rooms;
        }

        public Room GetById(int id)
        {
            return _roomDal.Get(x => x.Id == id);
        }

        public void TransactionalOperation(Room room1, Room room2)
        {
            _roomDal.Add(room1);
            _roomDal.Update(room2);
        }

        public Room Update(Room room)
        {
            return _roomDal.Update(room);
        }
    }
}
