using Newtonsoft.Json;
using RedisCacheTest.Core.Helpers;
using RedisCacheTest.Core.Models;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCacheTest.Core.Redis
{
    public class TestCacheAdapter
    {
        public IEnumerable<ChatRoomModel> Get(string key)
        {
            List<ChatRoomModel> result = new List<ChatRoomModel>();
            string q = RedisConnectHelper.ConnectionManager.GetDatabase(DB).StringGet(key);
            return String.IsNullOrEmpty(q) ? result : JsonConvert.DeserializeObject<IEnumerable<ChatRoomModel>>(q);
        }

        public bool Set(string key, string value)
        {

            return RedisConnectHelper.ConnectionManager.GetDatabase(DB).StringSet(key, value);
        }

        public bool Remove(string key)
        {
            return RedisConnectHelper.ConnectionManager.GetDatabase(DB).KeyDelete(key);
        }
        public void subscrite()
        {
            ISubscriber sub = RedisConnectHelper.ConnectionManager.GetSubscriber();
            sub.Subscribe("SamSamSam", (channel, message) => { Console.WriteLine(message); });
        }

        public void publish()
        {
            ISubscriber sub = RedisConnectHelper.ConnectionManager.GetSubscriber();
            sub.Publish("SamSamSam","沒有人這樣做的啦");
        }

        public int DB { set; get; } = 0;
    }
}
