using System;

namespace Lab3
{
    class WrongEmailAdressException : Exception
    {
        public WrongEmailAdressException(string message) : base(message)
        {
        }
    }
}
