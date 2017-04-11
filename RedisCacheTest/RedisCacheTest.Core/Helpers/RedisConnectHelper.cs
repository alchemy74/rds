using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCacheTest.Core.Helpers
{
    public static class RedisConnectHelper
    {
        public static void initial()
        {
            RedisConnectHelper.ConnectionManager = ConnectionMultiplexer.Connect("tpe-nosql-db-01.tpe.tecyt.com:6379");
        }

        




        public static ConnectionMultiplexer ConnectionManager { get; set; }
    }
}
