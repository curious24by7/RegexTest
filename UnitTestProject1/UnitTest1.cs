using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexTest;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {   //Arrange
        //Act
        //Assert
        [TestMethod]
        public void TestFirstNameReturnsTrue()
        {
            RegexPatterns firstname = new RegexPatterns();
            bool result = firstname.ValidateName("Soham");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestLastNameReturnsTrue()
        {   
            RegexPatterns lastname = new RegexPatterns();
            bool resultlastname = lastname.ValidateLastName("Dhamnaskar");
            Assert.IsTrue(resultlastname);
        }
        [TestMethod]
        public void TestPhoneNumberReturnsTrue()
        {
            RegexPatterns phonenum = new RegexPatterns();
            bool resultphonenum = phonenum.ValidatePhoneNum("91 1234567890");
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
