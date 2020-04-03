using PVMS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PVMS.Businesslayer.Interfaces
{
    public interface IUserServices
    {
        bool RegisterUser(User user);
        bool Loginuser(string Email, string Password);
        bool ApplyPassport(Passport passport);
        bool ApplyVisa(Visa visa);
        bool PassportRenewal(ReIssue reIssue);
        bool VisaCancellation(string VisaNumber, int UserId, DateTime DateOfIssue);
    }
}
