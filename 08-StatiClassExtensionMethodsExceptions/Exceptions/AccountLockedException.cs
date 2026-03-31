using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Exceptions
{
    using System;

    public class AccountLockedException : Exception
    {
        public AccountLockedException() : base("Account is locked!") { }
    }
}
