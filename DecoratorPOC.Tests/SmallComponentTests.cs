using DecoratorPOC.Infrastructure.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPOC.Tests
{
    [TestClass]
    public class Small_Component_Service_Should
    {
        [TestMethod]
        public void Return_Valid_Small_Component()
        {
            var svc = new SmallComponentService();
            var smallComponent = svc.GetSmallComponent();

            Assert.AreEqual(3.01m, smallComponent.GetCost());
            Assert.AreEqual("Small component", smallComponent.GetDescription());
        }
    }
}
