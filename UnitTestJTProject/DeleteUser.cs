using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentLayer;
using System;

namespace UnitTestJTProject
{
    [TestClass]
    public class DeleteUser
    {
        private frmManage frmmanage;
        [TestInitialize]
        public void Initialize()
        {
            frmmanage = new frmManage();
        }
        [TestMethod]
        // Test corret delete user
        public void TestDeleteUserCorrect()
        {
            frmmanage.AddNV("N20", "Nhân viên để xóa", ".", "0", "0", 0, "0");
            string id;
            bool result = frmmanage.DeleteUser(id);
            Assert.IsTrue(result);
        }
    }
}
