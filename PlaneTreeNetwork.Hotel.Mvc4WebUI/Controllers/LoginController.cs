using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlaneTreeNetwork.Hotel.Mvc4WebUI.Controllers
{
    public class LoginController : Controller
    {
        private IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
     

        [HttpPost]
        public ActionResult Index(User user)
        {
            _userService.GetByUserNameAndPassword(user.UserName,user.UserPassword);
            return View();
        }
    }
}