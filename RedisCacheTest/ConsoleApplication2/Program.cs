using RedisCacheTest.Core.Helpers;
using RedisCacheTest.Core.UIDatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisConnectHelper.initial();
            ChatRoomUIData ChatRoomUIData = new ChatRoomUIData();
            //監聽
            while (true)
            {

            Console.ReadKey();
            ChatRoomUIData.publish();

            }
        }


    }
}
