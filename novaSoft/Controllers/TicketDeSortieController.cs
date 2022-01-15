using novaSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace novaSoft.Controllers
{
    public class TicketDeSortieController : Controller
    {
        // GET: TicketDeSortie
        public ActionResult Index()
        {
            return View();
        }


        /* [HttpPost]
         public  ActionResult Create(TicketDeSortie ticketDeSortie)
         {

             HttpClient client = new HttpClient();
             client.BaseAddress = new Uri("http://localhost:8081/TicketDeSortie/");

              client.PostAsJsonAsync<TicketDeSortie>("add", ticketDeSortie).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());
 *//*

             HttpResponseMessage response = (await client.GetAsync("LastEleveId"));

             if (response.IsSuccessStatusCode)
             {
                 ViewBag.result = response.Content.ReadAsAsync<Eleve>().Result;

                 long Eleveid = ViewBag.result.eleveId;

                 return RedirectToAction("EleveContent/" + Eleveid);

             }
             else
             {
                 ViewBag.result = "error haha";
                 return RedirectToAction("EleveContent/" + 1);
             }
 *//*
             return View(ticketDeSortie);
         }*/


   
        public ActionResult Create(TicketDeSortie ticketDeSortie)
        {

            if (ModelState.IsValid)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8081/TicketDeSortie/");

                client.PostAsJsonAsync<TicketDeSortie>("add", ticketDeSortie).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());



                return View("Create");
            }
            return View();

           
        }


        [HttpGet]
        public ActionResult SearchByMatricule(String matricule)
        {
       
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8081/eleve/");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage resp = Client.GetAsync("SearchByMatricule/" + matricule).Result;





            if (resp.IsSuccessStatusCode)
            {
                ViewBag.result = resp.Content.ReadAsAsync<IEnumerable<Eleve>>().Result;
            }
            else
            {
                ViewBag.result = "ERROR ah ahahhh" + matricule;
            }

           
            return View();
        }



        }
}