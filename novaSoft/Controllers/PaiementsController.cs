using novaSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace novaSoft.Controllers
{
    public class PaiementsController : Controller
    {
        // GET: Paiements
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EleveContent(int id, string paiementMois, int montant)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8081/Paiement/");

            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage resp = Client.GetAsync("update/" + id + "/" + paiementMois + "/" + montant).Result;

            if (resp.IsSuccessStatusCode)
            {
                ViewBag.resp = resp.Content.ReadAsAsync<Paiements>().Result;

                return RedirectToAction("EleveContent/" + id);

            }

            else
            {
                ViewBag.result = "error haha";
                return RedirectToAction("/" + id);
            }

        }



    }
}