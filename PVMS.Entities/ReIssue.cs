using System;
using System.Collections.Generic;
using System.Text;

namespace PVMS.Entities
{
   public class ReIssue
    {
        public virtual string ReasonForReIssue { get; set; }
        public virtual int PassportId { get; set; }
    }
}
