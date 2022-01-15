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
    public class EleveController : Controller
    {
        // GET: Eleve
        public ActionResult Index()
        {

            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8081/eleve/");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Client.GetAsync("all").Result;

            if (response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<Eleve>>().Result;

            }
            else
            {
                ViewBag.result = "error haha";
            }
            return View();
        }

        
       
        [HttpGet]
        public ActionResult RechercheEleve(string elevSeacrh)
        {

            HttpClient client = new HttpClient();
            HttpResponseMessage resp = client.GetAsync("http://localhost:8081/eleve/Search/"+elevSeacrh).Result;

            if (resp.IsSuccessStatusCode)
            {
                ViewBag.result = resp.Content.ReadAsAsync<Eleve>().Result;
            }
            else
            {
                ViewBag.result = "ERROR ah ahahhh"+ elevSeacrh;
            }

            return View("RechercheEleve");
        }

        // GET: Eleve/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        

        // GET: Eleve/Create
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        // POST: Eleve/Create
        [HttpPost]
        public async Task<ActionResult> Create(Eleve eleve)
        {
            if (ModelState.IsValid)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8081/eleve/");

                await client.PostAsJsonAsync<Eleve>("add", eleve).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());


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

            }
            return View();


        }



    // GET: Eleve/Edit/5
    public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Eleve/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Eleve/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Eleve/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        public  async Task<ActionResult> EleveContent(long id)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8081/eleve/");
            /*
                        Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            */
            HttpResponseMessage response =  (await Client.GetAsync("http://localhost:8081/eleve/"+ id));

            
            if (response.IsSuccessStatusCode)
            {

                ViewBag.result =  response.Content.ReadAsAsync<Eleve>().Result;
            }
            else
            {
                ViewBag.result = "Une erreur s'est produite";
            }


            return View("EleveContent");
        }

        [HttpGet]
       public ActionResult Search(string searchingValue)
        {
            
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8081/eleve/");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage resp = Client.GetAsync("Search/" + searchingValue).Result;





            if (resp.IsSuccessStatusCode)
            {
                ViewBag.result = resp.Content.ReadAsAsync<IEnumerable<Eleve>>().Result;
            }
            else
            {
                ViewBag.result = "ERROR ah ahahhh" + searchingValue;
            }

            return View("Search");
        }

        [HttpGet]
        public ActionResult updatePaiement(int id, string paiementMois, int montant)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8081/Paiement/");

            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage resp = Client.GetAsync("update/" + id + "/" + paiementMois + "/" + montant).Result;

            if (resp.IsSuccessStatusCode)
            {
                ViewBag.resp = resp.Content.ReadAsAsync<Paiements>().Result;

                return View("updatePaiement");

            }

            else
            {
                ViewBag.result = "error haha";
                return View("updatePaiement");
            }

       
        }


    }


}
