using Newtonsoft.Json;
using RedisCacheTest.Core.Models;
using RedisCacheTest.Core.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCacheTest.Core.UIDatas
{
    public class ChatRoomUIData
    {
        public ChatRoomUIData()
        {
            this.TestCacheAdapter = new TestCacheAdapter();
        }

        public bool addComment(string name, string chatRoomID,string comment)
        {
            List<ChatRoomModel> q = this.TestCacheAdapter.Get(chatRoomID).ToList();
            ChatRoomModel chatRoomModel = new ChatRoomModel()
            {
                Name = name,
                Comment=comment,
                CreatedDate=DateTime.Now
            };
            q.Add(chatRoomModel);
            return this.TestCacheAdapter.Set(chatRoomID, JsonConvert.SerializeObject(q));
        }

        public IEnumerable<ChatRoomModel> getChatRoomMessage(string chatRoomID)
        {
            return this.TestCacheAdapter.Get(chatRoomID);
        }

        public void subscrite()
        {
            this.TestCacheAdapter.subscrite();
        }

        public void publish()
        {
            this.TestCacheAdapter.publish();
        }

        public TestCacheAdapter TestCacheAdapter { get; set; }
    }
}
