using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using PlaneTreeNetwork.Hotel.Mvc4WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlaneTreeNetwork.Hotel.Mvc4WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private IUserService _userService;
        public RegisterController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            user.UserRegistrationDate = DateTime.Now;// TODO:şuan üyelik tarihleri sistemle çalışacak.
            user.UserMembershipDate = DateTime.Now;//TODO:şuan üyelik tarihleri sistemle çalışacak.
            _userService.Add(user);
            return View();
        }

        public ActionResult KullaniciSozlesmesi()
        {
            return View();
        }

    }
}