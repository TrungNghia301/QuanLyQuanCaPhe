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
           

        }
    }
}
