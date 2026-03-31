using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Exceptions
{
    using System;

    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : base("Password is not valid!") { }

        public InvalidPasswordException(string message) : base(message) { }
    }
}
