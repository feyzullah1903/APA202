using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Exceptions
{
    using System;

    public class IncorrectPasswordException : Exception
    {
        public int AttemptsLeft { get; set; }

        public IncorrectPasswordException(int attemptsLeft)
            : base("Wrong password! Attempts left: " + attemptsLeft)
        {
            AttemptsLeft = attemptsLeft;
        }
    }
}
