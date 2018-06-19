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
                dbpersonlist = await new GatewayManager().GetPersonlistAsync(uri);
                return View(dbpersonlist);
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
        public async Task<IActionResult> Create(DataBasePerson p)
        {//De nieuwe persoon toevoegen aan de list in de api.
            try
            {
                var SuccessStatusCode = await new GatewayManager().PostPersonAsync(uri, p);
                if (SuccessStatusCode.IsSuccessStatusCode)
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

        public async Task<ActionResult> Edit(int Id)
        {//het openen van de edit pagina en de gegevens van de juiste persoon inladen
            dbperson = await new GatewayManager().GetPersonAsync(uri, Id);
            return View(dbperson);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(DataBasePerson p)
        {//De gegevens die aangepast moeten worden doorsturen naar de api.
            try
            {
                var SuccessStatusCode = await new GatewayManager().EditPersonAsync(uri, p);
                if (SuccessStatusCode.IsSuccessStatusCode)
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

        public async Task<ActionResult> Delete(int Id)
        {//Het scherm laden om de geselecteerde persoon te verwijderen.
            dbperson = await new GatewayManager().GetPersonAsync(uri, Id);
            return View(dbperson);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DataBasePerson p)
        {//De geselecteerde persoon verwijderen uit de list in de api.
            try
            {
                var SuccessStatusCode = await new GatewayManager().DeletePersonAsync(uri, p);
                if (SuccessStatusCode.IsSuccessStatusCode)
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