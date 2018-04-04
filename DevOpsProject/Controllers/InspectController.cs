using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class InspectController : Controller
    {
        // GET: /<controller>/
        public async Task<IActionResult> Index(string url = "http://webapicontainer/api/person/")
        {
            ViewBag.Url = url;
            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                HttpResponseMessage response = await client.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    ViewBag.ErrorMessage = response.ReasonPhrase;
                }
                ViewBag.StatusCode = response.StatusCode;
                return View();
            }
            catch (Exception ex)
            {

                ViewBag.ErrorMessage = ex.Message;
            }
            return View();
        }
    }
}
