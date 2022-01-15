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
    public class ObjetSaisieController : Controller
    {
        // GET: ObjetSaisie
        public ActionResult Index()
        {
            return View();
        }

        // GET: ObjetSaisie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ObjetSaisie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ObjetSaisie/Create
        [HttpPost]
        public ActionResult Create(ObjetSaisie objetSaisie)
        {

            if (ModelState.IsValid)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8081/ObjetSaisi/");

                client.PostAsJsonAsync<ObjetSaisie>("add", objetSaisie).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());

                return View("Create");
            }

            return View();

              
            /*try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }*/
        }



        [HttpGet]
        public ActionResult  SearchByMatricule(string searchingValue)
        {

            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:8081/eleve/");
            HttpResponseMessage resp = Client.GetAsync("SearchByMatricule/" + searchingValue).Result;

            if (resp.IsSuccessStatusCode)
            {
                ViewBag.result = resp.Content.ReadAsAsync<Eleve>().Result;
            }
            else
            {
                ViewBag.result = "ERROR ah ahahhh" + searchingValue;
            }

            return View("SearchByMatricule");
        }

        // GET: ObjetSaisie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ObjetSaisie/Edit/5
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

        // GET: ObjetSaisie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ObjetSaisie/Delete/5
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
    }
}
