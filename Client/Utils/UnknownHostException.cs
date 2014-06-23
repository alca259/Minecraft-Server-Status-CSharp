using System;
using Client.Resources;

namespace Client.Utils
{
    public class UnknownHostException : Exception
    {
        public UnknownHostException() : base(Messages.UnknownHost)
        {
        }
    }
}
