using System;
using System.Collections.Generic;
using System.Text;

namespace PVMS.Entities
{
   public class User
    {
        public virtual int UserId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string SurName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual string Address { get; set; }
        public virtual string ContactNo { get; set; }
        public virtual string Email  { get; set; }
        public virtual string Qualification { get; set; }
        public virtual string Gender { get; set; }
        public virtual string ApplyType { get; set; }
        public virtual string HintPassword { get; set; }
        public virtual string HintAnswer { get; set; }
        public virtual string Password { get; set; }



    }
}
