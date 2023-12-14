using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentLayer;
using System;

namespace UnitTestJTProject
{
    [TestClass]
    public class DeleteCoffee
    {
        private frmThemHang frmthemhang;
        private frmManage frmmanage;
        [TestInitialize]
        public void Initialize()
        {
            frmthemhang = new frmThemHang();
            frmthemhang.AddCoffee("CoffeetoDelete", 0, DateTime.Now, DateTime.Now.AddDays(20), 0, 0, "");
        }
        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}
