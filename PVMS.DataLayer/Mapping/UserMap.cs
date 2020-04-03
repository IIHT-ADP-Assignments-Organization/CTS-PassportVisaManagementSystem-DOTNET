using FluentNHibernate.Mapping;
using PVMS.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PVMS.DataLayer.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.UserId);

            Map(x => x.FirstName);
            Map(x => x.SurName);
            Map(x => x.DateOfBirth);
            Map(x => x.Address);
            Map(x => x.ContactNo);
            Map(x => x.Email);
            Map(x => x.Qualification);
            Map(x => x.Gender);
            Map(x => x.ApplyType);
            Map(x => x.HintPassword);
            Map(x => x.HintAnswer);
            Table("user");

        }
    }
}
