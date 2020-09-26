using System;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PlaneTreeNetwork.Hotel.Business.Concrete.Managers;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.Entities.Concrete;

namespace PlaneTreeNetwork.Business.Tests
{
    [TestClass]
    public class CustomerManagerTests
    {
        //[ExpectedException(typeof(ValidationException))]
        //[TestMethod]
        //public void Customer_add_validation_check()
        //{
        //    Mock<ICustomerDal> mock = new Mock<ICustomerDal>();
        //    CustomerManager customerManager = new CustomerManager(mock.Object);

        //    customerManager.Add(new Customer());
        //}

        //[ExpectedException(typeof(ValidationException))]
        //[TestMethod]
        //public void Customer_update_validation_check()
        //{
        //    Mock<ICustomerDal> mock = new Mock<ICustomerDal>();
        //    CustomerManager customerManager = new CustomerManager(mock.Object);

        //    customerManager.Update(new Customer());
        //}
    }
}
