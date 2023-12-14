using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresentLayer;
using System;

namespace UnitTestJTProject
{
    [TestClass]
    public class AddUser
    {
        private frmManage frmmange;
        [TestInitialize]
        public void Initialize()
        {
            frmmange = new frmManage();
        }
        [TestMethod]
        // Add with same user existed
        //N01/Nguyễn Trung Nghĩa/Trà Vinh/nghia2002@gmail.com/31000/admin
        public void TestAddSame()
        {
           bool result = frmmange.AddNV("N01", "Nguyễn Trung Nghĩa", "Trà Vinh","0355948202", "nghia2002@gmail.com", 31000, "admin");
            Assert.IsFalse(result);
        }
        [TestMethod]
        // Add with not same name but same account (admin is username of N01)
        public void TestAddSameAccount()
        {
            bool result = frmmange.AddNV("N10", "Nguyễn Trung Nghia", "Trà Vinh", "0355948202", "nghia2002@gmail.com", 31000, "admin");
            Assert.IsFalse(result);
        }
        [TestMethod]
        // Correct add id user not existed and don't same account with another user 
        public void TestAddCorrect()
        {
            bool result = frmmange.AddNV("N10", "Nguyễn Trung Nghĩa", "Trà Vinh", "0355948202", "nghia2002@gmail.com", 31000, "staff1");
            Assert.IsTrue(result);
            frmmange.DeleteNV("N10");
        }
    }
}
