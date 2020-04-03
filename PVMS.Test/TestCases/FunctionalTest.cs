using NSubstitute;
using PVMS.Businesslayer.Services;
using PVMS.DataLayer.NHibernateConfiguration;
using PVMS.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PVMS.Test.TestCases
{
    public class FunctionalTest
    {
        private readonly UserServices _Userservice;
        
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _Userservice = new UserServices(_session);
           
        }

        [Fact]
        public void Test_for_RegisterUser()
        {
            User user = new User()
            {
                UserId = 1,
                DateOfBirth = DateTime.Now,
                Address = "aa",
                ApplyType = "dd",
                ContactNo = "1111",
                Email = "dd@gmail.com",
                FirstName = "ddd",
                Gender = "ff",
                HintAnswer = "ff",
                HintPassword = "ff",
                Password = "ff",
                Qualification = "ff",
                SurName = "ff"
            };

            var result = _Userservice.RegisterUser(user);
            Assert.True(result);

        }


        [Fact]
        public void Test_for_Loginuser()
        {
            User user = new User()
            {
                
                Email = "dd@gmail.com",
               
                Password = "ff",
                
            };

            var result = _Userservice.Loginuser(user.Email,user.Password);
            Assert.True(result);

        }

        [Fact]
        public void Test_for_ApplyPassport()
        {
            Passport passport = new Passport()
            {
                BookletType="ff",
                City="ff",
                Country="ff",
                IssueDate=DateTime.Now,
                PassportNumber="dd",
                Pin=111,
                TypeOfServices="dd",
                State="ff",
                UserId=1
                

            };

            var result = _Userservice.ApplyPassport(passport);
            Assert.True(result);

        }

        [Fact]
        public void Test_for_ApplyVisa()
        {
            Visa visa = new Visa()
            {
                RegistrationCost = 11,
                DateOfApplication = DateTime.Now,
                DateOfExpiry = DateTime.Now,
                DateOfIssue = DateTime.Now,
                Destination = "ss",
                EmployeeOccupation = "qq",
                UserId = 1,
                VisaId = 1,
                VisaNumber = "aa"
            };

            var result = _Userservice.ApplyVisa(visa);
            Assert.True(result);

        }

        public void Test_for_PassportRenewal()
        {
            ReIssue reIssue = new ReIssue()
            {
                PassportId = 1,
                ReasonForReIssue = "dddd"
            };

            var result = _Userservice.PassportRenewal(reIssue);
            Assert.True(result);

        }
        [Fact]
        public void Test_for_VisaCancellation()
        {
            Visa visa = new Visa()
            {
                
                DateOfIssue = DateTime.Now,
               
                UserId = 1,
               
                VisaNumber = "aa"
            };

            var result = _Userservice.VisaCancellation(visa.VisaNumber,visa.UserId,visa.DateOfIssue);
            Assert.True(result);

        }







    }
}
