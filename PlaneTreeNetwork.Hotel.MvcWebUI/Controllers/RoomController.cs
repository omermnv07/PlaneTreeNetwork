using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using PlaneTreeNetwork.Hotel.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlaneTreeNetwork.Hotel.MvcWebUI.Controllers
{
    public class RoomController : Controller
    {
        private IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        // GET: Room
        public ActionResult Index()
        {
            var model = new RoomListViewModel
            {
                Room = _roomService.GetAll()
            };

            return View(model);
        }

        public string Add()
        {
            _roomService.Add(new Room
            {
               Id = 1,
               OtelId=2,
               RoomName = "Deneme Oda1"
            });
            return "Added";
        }

        public string AddUpdate()
        {
            _roomService.TransactionalOperation(new Room
            {
                Id = 1,
                OtelId = 2,
                RoomName = "Deneme Oda1"
            }, new Room
            {
                Id = 1,
                OtelId = 2,
                RoomName = "Deneme Oda1"
            }
            );
            return "Done";
        }
    }
}