using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using UserRegistrationWithMSTesting;
using UserReg_Test;
using User_Registration_Test;
namespace UserReg_Test
{
    [TestClass]
    public class UnitTest1
    {
       // [TestMethod]
       // public void TestMethod1()
        //{
            UserRegPattern userRegPattern = new UserRegPattern();


        //Right firstname
            [TestMethod]
            public void Given_Right_FirstName_ReturnTrue()
            {
                bool actual = userRegPattern.ValidateFirstName("rushi");
                bool expected = false;
                Assert.AreEqual(expected, actual);
            }

        //Wrong firstname
            [TestMethod]
            public void Given_Wrong_FirstName_ReturnFalse()
            {
                bool actual = userRegPattern.ValidateFirstName("ram");
                bool expected = false;

                Assert.AreEqual(expected, actual);
            }

        //Right lastname
            [TestMethod]
            public void Given_Right_LastName_ReturnTrue()
            {
                bool actual = userRegPattern.ValidateLastName("Patil");
                bool expected = true;

                Assert.AreEqual(expected, actual);
            }

        //Wrong lastname
            [TestMethod]
            public void Given_Wrong_LastName_ReturnFalse()
            {
                bool actual = userRegPattern.ValidateLastName("patil");
                bool expected = false;

                Assert.AreEqual(expected, actual);
            }


       //Wrong lastname
            [TestMethod]
             public void Given_wrong_LastName_ReturnFalse()
             {
              bool actual = userRegPattern.ValidateLastName("mali");
              bool expected = false;

              Assert.AreEqual(expected, actual);
             }

        // Right email
            [TestMethod]
            public void Given_Right_Email_ReturnTrue()
            {
                bool actual = userRegPattern.ValidateEmail("abc12@gmail.com");
                bool expected = true;

                Assert.AreEqual(expected, actual);
            }

        //wrong email
            [TestMethod]
            public void Given_Wrong_Email_ReturnFalse()
            {
                bool actual = userRegPattern.ValidateEmail("abc@@gmail.com");
                bool expected = false;

                Assert.AreEqual(expected, actual);
            }

        //Right mobile no
            [TestMethod]
            public void Given_Right_MobileNo_ReturnTrue()
            {
                bool actual = userRegPattern.ValidateMobileNo("918959886657");
                bool expected = true;

                Assert.AreEqual(expected, actual);
            }

        //Wrong mobile number
            [TestMethod]
            public void Given_Wrong_MobileNo_ReturnFalse()
            {
                bool actual = userRegPattern.ValidateMobileNo("4881058544");
                bool expected = false;

                Assert.AreEqual(expected, actual);
            }


       // Right password     
            [TestMethod]
            public void Given_Right_Password_ReturnTrue()
            {
                bool actual = userRegPattern.ValidatePassword("A#3aFaaET2");
                bool expected = true;
                Assert.AreEqual(expected, actual);
            }
       //Wrong password
            [TestMethod]
            public void Given_Wrong_Password_ReturnFalse()
            {
                bool actual = userRegPattern.ValidatePassword("abCD12");
                bool expected = false;

                Assert.AreEqual(expected, actual);
            }
       // }
    }
}