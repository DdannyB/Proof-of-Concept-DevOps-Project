using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DevOpsProject.Models;

namespace DevOpsProject.Controllers
{
    public class DatabaseController : Controller
    {
        public Names name = new Names();
        public static string uri = "http://" + Environment.GetEnvironmentVariable("WEBAPI_ENVIRONMENT") + "/api/database/";
        public static List<Names> names = new List<Names>();

        private IActionResult RedirectToHome()
        {//Terug gaan naar de Index pagina.
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri);
                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    String responseString = await response.Content.ReadAsStringAsync();
                    names = JsonConvert.DeserializeObject<List<Names>>(responseString);
                    return View(names);
                }
            }
            catch (Exception ex)
            {

                return View(new List<Names> {
                    new Names{
                        Name = ex.Message
                    }
                });
            }

            //Het ophalen van de persoon gegevens in de api.
            return View();
        }

        public ActionResult Create()
        {//Het scherm voor het toevoegen van een persoon
            return View();
        }

        [HttpPost]
        public IActionResult Create(Names p)
        {//De nieuwe persoon toevoegen aan de list in de api.

            try
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(p), System.Text.Encoding.UTF8, "application/json");

                HttpClient client = new HttpClient();
                var post = client.PostAsync(uri, content);
                post.Wait();
                var result = post.Result;

                if (result.IsSuccessStatusCode)
                {
                    return RedirectToHome();
                }

                return View(p);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public ActionResult Edit(int Id)
        {//het openen van de edit pagina en de gegevens van de juiste persoon inladen
            name = names.Where(x => x.Id == Id).FirstOrDefault();
            return View(name);
        }

        [HttpPost]
        public IActionResult Edit(Names p)
        {//De gegevens die aangepast moeten worden doorsturen naar de api.
            HttpContent content = new StringContent(JsonConvert.SerializeObject(p), System.Text.Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            var post = client.PutAsync(uri + p.Id, content);
            post.Wait();
            var result = post.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToHome();
            }

            return View(p);
        }

        public ActionResult Delete(int Id)
        {//Het scherm laden om de geselecteerde persoon te verwijderen.
            name = names.Where(x => x.Id == Id).FirstOrDefault();
            return View(name);
        }

        [HttpPost]
        public IActionResult Delete(Names p)
        {//De geselecteerde persoon verwijderen uit de list in de api.
            HttpContent content = new StringContent(JsonConvert.SerializeObject(p), System.Text.Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            var post = client.DeleteAsync(uri + p.Id);
            post.Wait();
            var result = post.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToHome();
            }

            return View(p);
        }
    }
}