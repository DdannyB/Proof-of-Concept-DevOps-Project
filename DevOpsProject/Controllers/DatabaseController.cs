using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DevOpsProject.Models;
using DevOpsProject.Libs.GatewayManager;

namespace DevOpsProject.Controllers
{
    public class DatabaseController : Controller
    {
        HttpClient client = new HttpClient();
        HttpContent content;
        HttpResponseMessage result;
        HttpRequestMessage request;

        public DataBasePerson dbperson = new DataBasePerson();      
        public static List<DataBasePerson> dbpersonlist = new List<DataBasePerson>();
        public static string uri = "http://" + Environment.GetEnvironmentVariable("WEBAPI_ENVIRONMENT") + "/api/database/";
        
        public IActionResult RedirectToHome()
        {
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var lst = await new GatewayManager().GetAsync(uri);
                return View(lst);
            }
            catch (Exception ex)
            {
                return View(new List<DataBasePerson> {
                    new DataBasePerson{
                        Name = ex.Message
                    }
                });
            }
        }

        public ActionResult Create()
        {//Het scherm voor het toevoegen van een persoon
            return View();
        }

        [HttpPost]
        public IActionResult Create(DataBasePerson p)
        {//De nieuwe persoon toevoegen aan de list in de api.
            //try
            //{
            //    var SuccessStatusCode = new GatewayManager().Post(uri, p);

            //    if (SuccessStatusCode == true)
            //    {
            //        return RedirectToHome();
            //    }
            //    return View(p);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            try { 
            content = new StringContent(JsonConvert.SerializeObject(p), System.Text.Encoding.UTF8, "application/json");

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
            dbperson = dbpersonlist.Where(x => x.Id == Id).FirstOrDefault();
            return View(dbperson);
        }

        [HttpPost]
        public IActionResult Edit(DataBasePerson p)
        {//De gegevens die aangepast moeten worden doorsturen naar de api.
            content = new StringContent(JsonConvert.SerializeObject(p), System.Text.Encoding.UTF8, "application/json");

            var post = client.PutAsync(uri + p.Id, content);
            post.Wait();
            result = post.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToHome();
            }

            return View(p);
        }

        public ActionResult Delete(int Id)
        {//Het scherm laden om de geselecteerde persoon te verwijderen.
            dbperson = dbpersonlist.Where(x => x.Id == Id).FirstOrDefault();
            return View(dbperson);
        }

        [HttpPost]
        public IActionResult Delete(DataBasePerson p)
        {//De geselecteerde persoon verwijderen uit de list in de api.
            try
            {
                content = new StringContent(JsonConvert.SerializeObject(p), System.Text.Encoding.UTF8, "application/json");

                var post = client.DeleteAsync(uri + p.Id);
                post.Wait();
                result = post.Result;

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
    }
}