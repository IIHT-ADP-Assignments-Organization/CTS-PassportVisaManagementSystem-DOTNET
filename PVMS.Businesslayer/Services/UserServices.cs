using PVMS.Businesslayer.Interfaces;
using PVMS.DataLayer.NHibernateConfiguration;
using PVMS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PVMS.Businesslayer.Services
{
    public class UserServices : IUserServices
    {
        private readonly IMapperSession _session;

        public UserServices(IMapperSession session)
        {
            _session = session;
        }
        
        public bool ApplyPassport(Passport passport)
        {
            return true;
        }

        public bool ApplyVisa(Visa visa)
        {
            return true;
        }

        public bool Loginuser(string Email, string Password)
        {
            return true;
        }

        public bool PassportRenewal(ReIssue reIssue)
        {
            return true;
        }

        public bool RegisterUser(User user)
        {
            return true;
        }

        public bool VisaCancellation(string VisaNumber, int UserId, DateTime DateOfIssue)
        {
            return true;
        }
    }
}
