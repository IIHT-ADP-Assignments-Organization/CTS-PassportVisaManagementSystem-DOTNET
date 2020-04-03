using System;
using System.Collections.Generic;
using System.Text;

namespace PVMS.Test.Exceptions
{
   public class EmailAlreadyExistException:Exception
    {
        public string Messages = "User Not Found ";

        public EmailAlreadyExistException(string message)
        {
            Messages = message;
        }
    }
}
