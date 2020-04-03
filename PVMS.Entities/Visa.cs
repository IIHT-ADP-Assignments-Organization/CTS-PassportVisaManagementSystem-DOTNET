using System;
using System.Collections.Generic;
using System.Text;

namespace PVMS.Entities
{
   public class Visa
    {
        public virtual int VisaId { get; set; }
        public virtual int UserId { get; set; }
        public virtual string Destination { get; set; }
        public virtual string EmployeeOccupation { get; set; }
        public virtual DateTime DateOfApplication { get; set; }
        public virtual DateTime DateOfIssue { get; set; }
        public virtual DateTime DateOfExpiry { get; set; }
        public virtual long RegistrationCost { get; set; }
        public virtual string VisaNumber { get; set; }
    }
}
