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
    public class CustomersController : ApiController
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public List<Customer> GetAll()
        {
            return _customerService.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerService.GetById(id);
        }

    }
}
