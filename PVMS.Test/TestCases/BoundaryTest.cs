using PVMS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PVMS.Test.TestCases
{
   public class BoundaryTest
    {

        [Fact]
        public void BoundaryTest_ForUser_Length()
        {

            User user = new User()
            {
                UserId =111
            };
            var MinLength = 9;
            var MaxLength = 9;

            //Action
            var actualLength = user.UserId.ToString().Length;


            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForPincode_Length()
        {

            Passport passport = new Passport()
            {
                Pin = 1114561
            };
            var MinLength = 6;
            var MaxLength = 6;

            //Action
            var actualLength = passport.Pin.ToString().Length;


            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForPhoneNo_Length()
        {

            User user = new User()
            {
                ContactNo = "1114561"
            };
            var MinLength = 10;
            var MaxLength = 10;

            //Action
            var actualLength = user.ContactNo.ToString().Length;


            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForIssueDate()
        {

            Passport passport = new Passport()
            {
                IssueDate = DateTime.Now
            };


            //Action
            var DateFormat = passport.IssueDate;


            //Assert
            Assert.Matches(DateTime.Now.ToString(), DateFormat.ToString());
        }
        [Fact]
        public void BoundaryTest_ForApplicationDate()
        {

            Visa visa = new Visa()
            {
                DateOfApplication = DateTime.Now
            };


            //Action
            var ApllicationDate = visa.DateOfApplication;


            //Assert
            Assert.Matches(DateTime.Now.ToString(), ApllicationDate.ToString());
        }
    }
}
