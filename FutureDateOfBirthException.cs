using System;

namespace Lab3
{
    class FutureDateOfBirthException : Exception
    {
        public FutureDateOfBirthException(string message) : base(message)
        {
        }
    }
}
