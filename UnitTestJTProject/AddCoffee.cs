using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentLayer;
using System;

namespace UnitTestJTProject
{
    [TestClass]
    public class AddCoffee
    {
        private frmThemHang frmthemhang;
        [TestInitialize]
        public void Initialize()
        {
            frmthemhang = new frmThemHang();
        }
        [TestMethod]
        // Test add coffee with the same name Latte
        public void TestAddSameCoffee()
        {
            bool result = frmthemhang.AddCoffee("Latte", 100, DateTime.Now, DateTime.Now.AddDays(30), 12000, 35000, ""); ;
            Assert.IsFalse(result);
        }
        
        [TestMethod]
        // Test add coffee with the blank name
        public void TestAddBlankCoffee()
        {
            bool result = frmthemhang.AddCoffee("", 100, DateTime.Now, DateTime.Now.AddDays(30), 12000, 35000, "");
            Assert.IsFalse(result);
        }
        [TestMethod]
        // Test add coffee don't have in database "BlackWhite"
        public void TestValidAddCoffee()
        {
           bool result = frmthemhang.AddCoffee("BlackWhite", 100, DateTime.Now, DateTime.Now.AddDays(30), 12000, 35000, "");
           Assert.IsTrue(result);
        }
    }
}
