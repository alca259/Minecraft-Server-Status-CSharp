using Client.Logic;

namespace Client.Utils
{
    public class AddressModel
    {
        public string HostIp { get; set; }
        public int HostPort { get; set; }
        public bool Favorite { get; set; }
        public QueryResponse Response { get; set; }
    }
}
