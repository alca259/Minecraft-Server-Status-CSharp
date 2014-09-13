using System;

namespace MSSUtils.Exceptions
{
    public class UnknownHostException : Exception
    {
        public UnknownHostException() : base("Unknown host")
        {
        }
    }
}
