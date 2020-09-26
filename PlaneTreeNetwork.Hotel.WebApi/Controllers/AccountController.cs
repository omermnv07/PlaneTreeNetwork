using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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
    public class AccountController : ApiController
    {
        IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public List<User> Get()
        {
            return _userService.GetAll();
        }

        [Route("api/user/Register")]
        [HttpPost]
        public User Add(User room)
        {
            return _userService.Add(room);
        }

        public User Update(User room)
        {
            return _userService.Update(room);
        }
        public User GetById(int id)
        {
            return _userService.GetById(id);
        }
    }
}
