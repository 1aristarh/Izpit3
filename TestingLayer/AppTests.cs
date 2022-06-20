using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
using ServiceLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestingLayer
{
    [TestClass]
    public class AppTests
    {
        AppContext ctx = DBContextManager.GetAppContext();
        App APP;

        [TestInitialize]
        public void Setup()
        {
            try
            {
                ctx.Delete("customid");
                //tries to delete the test user if tests have been ran before
            }
            catch (Exception e) { }
            App customitem = new App("customid", "Visual Studio", (decimal)49.99, "01.01.2019");
            ctx.Create(customitem);
            APP = customitem;
        }
        [TestCleanup]
        public void Cleanup()
        {
            ctx.Delete("customid");
            ctx.Create(APP);
        }
        [TestMethod]
        public void CreateTest()
        {
            Assert.IsNotNull(ctx.Read("customid"));
        }
        [TestMethod]
        public void ReadTest()
        {
            Assert.AreEqual("Visual Studio", ctx.Read("customid").Name);
        }
        [TestMethod]
        public void ReadAllTest()
        {
            Assert.IsNotNull(ctx.ReadAll());
        }
        [TestMethod]
        public void UpdateTest()
        {
            App newAPP = new App("customid", "Powerpoint", (decimal)0.00, "01.01.2016");
            ctx.Update(newAPP);
            Assert.AreEqual("Powerpoint", ctx.Read("customid").Name);
        }
        [TestMethod]
        public void DeleteTest()
        {
            ctx.Delete("customid");
            Assert.IsNull(ctx.Read("customid"));
            ctx.Create(APP);
        }

    }
}
