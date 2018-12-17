using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Internet internet = new ProxyInternet();
            internet.connectTo("google.com"); //Connecting to google.com
            internet.connectTo("facebook.com"); //Access denied to facebook.com
            internet.connectTo("dxc.com"); //Connecting to dxc.com
            Console.ReadKey();
        }
    }
}


