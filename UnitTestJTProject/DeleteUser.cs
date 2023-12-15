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
        // TS : create user wwith id "N20" to test delete
        public void TestDeleteUserCorrect()
        {
            frmmanage.AddNV("N20", "Nhân viên để xóa", ".", "0", "0", 0, "testAccount");
            string id = "N20";
            bool result = frmmanage.DeleteNV(id);
            Assert.IsTrue(result);
        }
        [TestMethod]
        // Test delete user with blank value
        public void TestBlankDeleteUser()
        {
            string id = "";
            bool result = frmmanage.DeleteNV(id);
            Assert.IsFalse(result);
        }
    }
}
