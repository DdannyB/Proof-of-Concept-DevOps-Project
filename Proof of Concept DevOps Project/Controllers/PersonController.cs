using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proof_of_Concept_DevOps_Project.Models;

namespace Proof_of_Concept_DevOps_Project.Controllers
{
    public class PersonController : Controller
    {
        public static List<Person> persons = new List<Person>();
        public static Person persoon = new Person();
        public static string uri = "http://localhost:8080/api/person";

        private IActionResult RedirectToHome()
        {//Terug gaan naar de Index pagina.
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Index()
        {//Het ophalen van de persoon gegevens in de api.
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri);
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                String responseString = await response.Content.ReadAsStringAsync();
                persons = JsonConvert.DeserializeObject<List<Person>>(responseString);
                return View(persons);
            }

            return View();
        }

        public ActionResult Create()
        {//Het scherm voor het toevoegen van een persoon
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person p)
        {//De nieuwe persoon toevoegen aan de list in de api.
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

        public ActionResult Edit(int Id)
        {//het openen van de edit pagina en de gegevens van de juiste persoon inladen
            persoon = persons.Where(x => x.Id == Id).FirstOrDefault();
            return View(persoon);
        }

        [HttpPost]
        public IActionResult Edit(Person p)
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
            persoon = persons.Where(x => x.Id == Id).FirstOrDefault();
            return View(persoon);
        }

        [HttpPost]
        public IActionResult Delete(Person p)
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
    
