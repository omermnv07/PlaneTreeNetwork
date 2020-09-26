using PlaneTreeNetwork.Core.CrossCuttingConcerns.Security.Web;
using PlaneTreeNetwork.Hotel.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlaneTreeNetwork.Hotel.MvcWebUI.Controllers
{

    public class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public ActionResult Index()
        {
            return View();
        }
        // GET: Account
        public ActionResult Login(string userName, string password)
        {
            var user = _userService.GetByUserNameAndPassword(userName, password);
            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                new Guid(),
                user.UserName,
                user.UserEmail,
                DateTime.Now.AddDays(15),
               _userService.GetUserRoles(user).Select(x=>x.RoleName).ToArray(),
                false,
                user.UserFirstName,
                user.UserLastName);
                return View(); //return "User is Authenticated!"
            }
            return View("User is NOT Authenticated!");//"User is NOT Authenticated!";
        }
    }
}