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
            frmmanage = new frmManage();
        }
        [TestMethod]
        // Delete Coffee with name CoffeetoDelete
        public void TestCorrect()
        {
            // Add to delete
            frmthemhang.AddCoffee("CoffeetoDelete", 0, DateTime.Now, DateTime.Now.AddDays(20), 0, 0, "");
            string c = null;
            bool result = frmmanage.DeleteCoffee(c, "CoffeetoDelete");
            Assert.IsTrue(result);
        }
        [TestMethod]
        // Delete Coffee with name blank/ blank
        public void TestBlankValue()
        {
            frmthemhang.AddCoffee("CoffeetoDelete", 0, DateTime.Now, DateTime.Now.AddDays(20), 0, 0, "");
            string c = null;
            string a = null;
            bool result = frmmanage.DeleteCoffee(c, a);
            Assert.IsFalse(result);
        }

    }
}
  