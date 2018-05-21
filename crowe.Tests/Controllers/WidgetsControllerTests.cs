using Microsoft.VisualStudio.TestTools.UnitTesting;
using crowe.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crowe.Application.Handlers;
using crowe.Application.Models;
using System.Web.Http;

namespace crowe.Controllers.Tests
{
    [TestClass()]
    public class WidgetsControllerTests
    {
        [TestMethod()]
        public void GetWidgetTest()
        {
            var wc = new WidgetsController();
            var result = wc.GetWidget("bed09fd4-a977-47b7-88aa-27d32881e50d");

            Assert.IsNotNull(result, "No widget found");
        }

        [TestMethod()]
        public void GetAllWidgetsTest()
        {
            var wc = new WidgetsController();
            var result = wc.GetAllWidgets();
            Assert.IsNotNull(result, "No widgets found");
        }
    }
}