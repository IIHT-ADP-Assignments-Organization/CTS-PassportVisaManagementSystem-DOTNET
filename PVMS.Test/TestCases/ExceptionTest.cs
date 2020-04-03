using NSubstitute;
using PVMS.Businesslayer.Services;
using PVMS.DataLayer.NHibernateConfiguration;
using PVMS.Entities;
using PVMS.Test.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PVMS.Test.TestCases
{
   public class ExceptionTest
    {
        private readonly UserServices _Userservice;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _Userservice = new UserServices(_session);

        }


        [Fact]
        public void ExceptionTestFor_FieldsCannotblank()
        {
            User user = new User()
            {
                UserId = 1,
                FirstName = "abc",
                SurName = "",
                DateOfBirth = DateTime.Now,
                Address = "gadag",
                ContactNo = "8987656778",
                Email = "example@gmail.com",
                Qualification = "",
                Gender = "male",
                ApplyType = "",
                HintPassword = "123",
                HintAnswer = "",
                Password = "123"

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _Userservice.RegisterUser(user));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_UserNotFound()
        {
            User user = new User()
            {
                Email = "example@gmail.com",
                Password = "123"

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _Userservice.Loginuser(user.Email, user.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_PassportFieldsCannotblank()
        {
            Passport passport = new Passport()
            {
                UserId = 1,
                Country = "abc",
                State = "",
                City = "",
                Pin = 1234,
                TypeOfServices = "",
                BookletType = "",
                
                IssueDate =DateTime.Now,
                
               
                PassportNumber = "123"

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _Userservice.ApplyPassport(passport));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }


        [Fact]
        public void ExceptionTestFor_EmailAlreadyExist()
        {
            User user = new User()
            {
                Email = "example@gmail.com"

            };
            //Assert
            var ex = Assert.Throws<EmailAlreadyExistException>(() => _Userservice.RegisterUser(user));
            Assert.Equal("Email Already Exist ", ex.Messages);
        }

    }
}
