using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsProject.Models;
using Microsoft.AspNetCore.Mvc;
using DevOpsProject.Libs.GatewayManager;

namespace DevOpsProject.Controllers
{
    public class TagsController : Controller
    {
        public Tags tagname = new Tags();
        public static List<Tags> tagslist = new List<Tags>();
        public static string uri = "http://" + Environment.GetEnvironmentVariable("WEBAPI_ENVIRONMENT") + "/api/tags/";

        public IActionResult RedirectToHome()
        {
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Index()
        {
             tagslist = await new GatewayManager().GetlistAsync<Tags>(uri);
            return View(tagslist);
        }


        public ActionResult Create()
        {//Het scherm voor het toevoegen van een persoon
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tags p)
        {//De nieuwe persoon toevoegen aan de list in de api.
            try
            {
                var SuccessStatusCode = await new GatewayManager().PostAsync<Tags>(uri, p);
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
            tagname = await new GatewayManager().GetAsync<Tags>(uri, Id);
            return View(tagname);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Tags p)
        {//De gegevens die aangepast moeten worden doorsturen naar de api.
            try
            {
                var SuccessStatusCode = await new GatewayManager().EditAsync<Tags>(uri + p.Id, p);
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
            tagname = await new GatewayManager().GetAsync<Tags>(uri, Id);
            return View(tagname);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Tags p)
        {//De geselecteerde persoon verwijderen uit de list in de api.
            try
            {
                var SuccessStatusCode = await new GatewayManager().DeleteAsync<Tags>(uri + p.Id, p);
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