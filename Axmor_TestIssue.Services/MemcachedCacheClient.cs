using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Axmor_TestIssue.Core.Interfaces;
using Enyim.Caching;
using Enyim.Caching.Configuration;
using Enyim.Caching.Memcached;

namespace Axmor_TestIssue.Services
{
    public class MemcachedCacheClient : ICacheProvider
    {
        private IMemcachedClientConfiguration GetConfig()
        {
            var config = new MemcachedClientConfiguration();
            config.Servers.Add(CreateIPEndPoint("127.0.0.1:11211"));
            return config;
        }


        public void Put(object o, string key, int expirationSeconds = 0)
        {
            using (var client = new MemcachedClient(GetConfig()))
            {
                if (expirationSeconds > 0)
                {
                    client.Store(StoreMode.Set, key, o, TimeSpan.FromSeconds(expirationSeconds));
                }
                else
                {
                    client.Store(StoreMode.Set, key, o, TimeSpan.FromDays(365));
                }
            }
        }

        public type Get<type>(string key)
        {
            try
            {
                using (var client = new MemcachedClient(GetConfig()))
                {
                    return client.Get<type>(key);
                }
            }
            catch (Exception)
            {

                return default(type);
            }

        }

        private static IPEndPoint CreateIPEndPoint(string endPoint)
        {
            string[] ep = endPoint.Split(':');
            if (ep.Length != 2) throw new FormatException("Invalid endpoint format");
            IPAddress ip;
            if (!IPAddress.TryParse(ep[0], out ip))
            {
                throw new FormatException("Invalid ip-adress");
            }
            int port;
            if (!int.TryParse(ep[1], NumberStyles.None, NumberFormatInfo.CurrentInfo, out port))
            {
                throw new FormatException("Invalid port");
            }
            return new IPEndPoint(ip, port);
        }

    }

}
