using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace DevOpsProject.Controllers
{
    public class SecretController : Controller
    {
        public async Task <IActionResult> Index()
        {
                HttpClient client = new HttpClient();
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "http://192.168.1.188:1230/secret");
                HttpResponseMessage response = await client.SendAsync(request);
                string key = "my_external_secret";
                ViewBag.Secret = GetSecretOrEnvVar(key);
                ViewBag.Key = key;
                ViewBag.StatusCode = response.StatusCode;
                return View();
        }

        public string GetSecretOrEnvVar(string key)
        {
            const string DOCKER_SECRET_PATH = "/run/secrets/";
            if (Directory.Exists(DOCKER_SECRET_PATH))
            {
                IFileProvider provider = new PhysicalFileProvider(DOCKER_SECRET_PATH);
                IFileInfo fileInfo = provider.GetFileInfo(key);
                if (fileInfo.Exists)
                {
                    using (var stream = fileInfo.CreateReadStream())
                    using (var streamReader = new StreamReader(stream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
            return "didnt work";
        }
    }
}