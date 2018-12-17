using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_pattern
{
    interface Internet
    {
        void connectTo(string host);
    }
    class RealInternet : Internet
    {
        public void connectTo(string host)
        {
            Console.WriteLine(String.Format("Connecting to {0}", host));
        }
    }
}
