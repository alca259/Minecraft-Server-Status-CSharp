using System;

namespace MSSModels
{
    public class AddressModel
    {
        public Guid Id { get; set; }
        public string HostIp { get; set; }
        public int HostPort { get; set; }
        public bool Favorite { get; set; }
        //public QueryResponse Response { get; set; }

        public string Text
        {
            get
            {
                if (Favorite) return "(*) " + HostIp + " : " + HostPort;
                return HostIp + " : " + HostPort;
            }
        }
    }
}
