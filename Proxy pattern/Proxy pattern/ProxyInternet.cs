using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_pattern
{
    class ProxyInternet : Internet
    {
        private List<string> _bannedHosts = new List<string>() { "delfi.com", "yahoo.com", "facebook.com" };
        private Internet _internet = new RealInternet();
       
        public void connectTo(string host)
        {
            //block access to banned hosts
            if(_bannedHosts.Contains(host))
            {
                Console.WriteLine("Access denied to {0}", host);
            } else
            {
                _internet.connectTo(host);
            }
        }
    }
}
