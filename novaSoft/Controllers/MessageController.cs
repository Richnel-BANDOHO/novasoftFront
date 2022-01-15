using novaSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace novaSoft.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Index()
        {
            return View();
        }

        //POST: CREATE

        [HttpPost]
        public ActionResult Create(Message msg)
        {


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8081/Message/");

            client.PostAsJsonAsync<Message>("add", msg).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());

            return RedirectToAction("Index");

        }
    }
}