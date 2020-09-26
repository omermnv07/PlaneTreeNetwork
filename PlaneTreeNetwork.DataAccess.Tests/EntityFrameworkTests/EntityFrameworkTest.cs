using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework;

namespace PlaneTreeNetwork.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_users()
        {
            EfUserDal efUserDal = new EfUserDal();

            var result = efUserDal.GetList();

            Assert.AreEqual(2,result.Count);
        }
        [TestMethod]
        public void Get_all_with_parameter_returns_fltered_users()
        {
            EfUserDal efUserDal = new EfUserDal();

            var result = efUserDal.GetList(p=>p.UserName.Contains("om"));

            Assert.AreEqual(1, result.Count);
        }
    }
}
