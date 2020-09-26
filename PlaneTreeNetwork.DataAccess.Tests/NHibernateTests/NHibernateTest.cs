using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework;
using PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate;
using PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate.Helpers;

namespace PlaneTreeNetwork.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_users()
        {
            NhUserDal efUserDal = new NhUserDal(new SqlServerHelper());

            var result = efUserDal.GetList();

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_fltered_users()
        {
            NhUserDal efUserDal = new NhUserDal(new SqlServerHelper());

            var result = efUserDal.GetList(p => p.UserName.Contains("om"));

            Assert.AreEqual(1, result.Count);
        }
    }
}
