﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexTest;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstNameReturnsTrue()
        {
            //Arrange
            RegexPatterns firstname = new RegexPatterns();
            //Act
            bool result = firstname.ValidateName("Soham");
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestLastNameReturnsTrue()
        {   
            //Arrange
            RegexPatterns lastname = new RegexPatterns();
            //Act
            bool resultlastname = lastname.ValidateLastName("Dhamnaskar");
            //Assert
            Assert.IsTrue(resultlastname);
        }
        [TestMethod]
        public void TestPhoneNumberReturnsTrue()
        {
            //Arrange
            RegexPatterns phonenum = new RegexPatterns();
            //Act
            bool resultphonenum = phonenum.ValidatePhoneNum("91 1234567890");
            //Assert
            Assert.IsTrue(resultphonenum);
        }
        [TestMethod]
        public void TestEmailIdReturnsTrue()
        {
            RegexPatterns emailid = new RegexPatterns();
            bool resultemailid = emailid.ValidateEmail("sohamdham123@gmail.com");
            Assert.IsTrue(resultemailid);
        }
        [TestMethod]
        public void TestPasswordReturnsTrue()
        {
            RegexPatterns pass = new RegexPatterns();
            bool resultpass = pass.ValidatePassword("46a4s5@Aknac");
            Assert.IsTrue(resultpass);
        }
    }
}
