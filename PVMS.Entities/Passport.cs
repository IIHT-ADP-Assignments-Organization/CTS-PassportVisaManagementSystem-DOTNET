using System;
using System.Collections.Generic;
using System.Text;

namespace PVMS.Entities
{
    public class Passport
    {
        public virtual int UserId { get; set; }
        public virtual string Country { get; set; }
        public virtual string State { get; set; }
        public virtual string City { get; set; }
        public virtual int Pin { get; set; }
        public virtual string TypeOfServices { get; set; }
        public virtual string BookletType { get; set; }
        public virtual DateTime IssueDate { get; set; }
        public virtual string PassportNumber { get; set; }
    }
}
