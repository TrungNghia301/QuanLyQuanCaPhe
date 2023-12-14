using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PresentLayer;

namespace UnitTestJTProject
{
    [TestClass]
    public class Login
    {
        private frmLogin loginForm;
        [TestInitialize]
        public void Setup()
        {
            loginForm = new frmLogin();
        }
        [TestMethod]//--> 1 TestCase
        // Check with valid account "admin/12345"
        public void TestCorrectAccount()
        {
            // Arrange                                                                          
            string validUsername = "admin";
            string validPassword = "12345";
            // Act
            bool result = loginForm.Login(validUsername, validPassword);
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        // Check with value blank/blank
        public void TestBlankValue()
        {
            // Arrange                                                                          
            string validUsername = " ";
            string validPassword = " ";
            // Act
            bool result = loginForm.Login(validUsername, validPassword);
            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        // Check with value blank/12345
        public void TestBlankUsername()
        {
            // Arrange                                                                          
            string validUsername = "";
            string validPassword = "12345";
            // Act
            bool result = loginForm.Login(validUsername, validPassword);
            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        // Check with value 12345/blank
        public void TestBlankPassword()
        {
            // Arrange                                                                          
            string validUsername = "admin";
            string validPassword = "";
            // Act
            bool result = loginForm.Login(validUsername, validPassword);
            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        // Check with invalid username abc/12345
        public void TestInvalidUsername()
        {
            // Arrange                                                                          
            string validUsername = "abc";
            string validPassword = "12345";
            // Act
            bool result = loginForm.Login(validUsername, validPassword);
            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        // Check with invalid password admin/abc
        public void TestInvalidPassword()
        {
            // Arrange                                                                          
            string validUsername = "admin";
            string validPassword = "abc";
            // Act
            bool result = loginForm.Login(validUsername, validPassword);
            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        // Check with invalid account abc/abc
        public void TestInvalidAccount()
        {
            // Arrange
            string validUsername = "abc";
            string validPassword = "abc";
            // Act
            bool result = loginForm.Login(validUsername, validPassword);
            // Assert
            Assert.IsFalse(result);
        }
    }
}
