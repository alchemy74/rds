using RedisCacheTest.Core.Models;
using RedisCacheTest.Core.UIDatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedisCacheTest.Controllers
{
    public class SamController : Controller
    {
        public ChatRoomUIData chatRoomUIData = new ChatRoomUIData();
        // GET: Sam
        public ViewResult Index()
        {
            return View();
        }

        public ActionResult GetChatRoom(string chatRoomID)
        {
           return View(this.chatRoomUIData.getChatRoomMessage(chatRoomID));
        }
    }
}