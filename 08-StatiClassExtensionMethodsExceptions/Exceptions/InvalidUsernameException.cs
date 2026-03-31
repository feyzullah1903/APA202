using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Exceptions
{
    using System;

    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException() : base("Username is not valid!") { }

        public InvalidUsernameException(string message) : base(message) { }
    }
}
