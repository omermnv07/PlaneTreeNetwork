using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.MvcWebUI.Models;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlaneTreeNetwork.Hotel.MvcWebUI.Controllers
{
    public class CustomerController : Controller
    {

        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public ActionResult Index()
        {
            var model = new CustomerListViewModel
            {
                Customer = _customerService.GetAll()
            };
            return View(model);
        }

        public string Add()
        {
            _customerService.Add(new Customer
            {
                CustomerId = 1,
                CustomerLastName = "Manav",
                CustomerName = "aaa",
                CustomerYearOfBirth = new DateTime(),
                UserId = 1
            });
            return "Added";
        }

        public string AddUpdate()
        {
            _customerService.TransactionalOperation(new Customer
            {
                CustomerId = 1,
                CustomerLastName = "Manav",
                CustomerName = "saaaaaa",
                CustomerYearOfBirth = new DateTime(),
                UserId = 2
            }, new Customer
            {
                CustomerId = 2,
                CustomerLastName = "Manav",
                CustomerName = "sssssss",
                CustomerYearOfBirth = new DateTime(),
                UserId = 2
            }
            );
            return "Done";
        }
    }
}