using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaneTreeNetwork.Hotel.WebApi.Controllers
{
    public class RoomsController : ApiController
    {
        private IRoomService _roomService;
        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public List<Room> Get()
        {
            return _roomService.GetAll();
        }

        public Room Add(Room room)
        {
            return _roomService.Add(room);
        }

        public Room Update(Room room)
        {
            return _roomService.Update(room);
        }
        public Room GetById(int id)
        {
            return _roomService.GetById(id);
        }

    }
}
