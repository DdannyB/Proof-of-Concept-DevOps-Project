using DevOpsProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DevOpsProject.Libs.GatewayManager
{
    public class GatewayManager
    {
        HttpClient client;
        HttpResponseMessage result;
        HttpContent content;

        public async Task<List<DataBasePerson>> GetAsync(string uri)
        {
            using (client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                var result = await client.SendAsync(request);

                if (result.IsSuccessStatusCode)
                {
                    String responseString = await result.Content.ReadAsStringAsync();
                    var dbpersonlist = JsonConvert.DeserializeObject<List<DataBasePerson>>(responseString);
                    return dbpersonlist;
                }
                return null;
            }
        }

        public Boolean Post(string uri, DataBasePerson p)
        {
          content = new StringContent(JsonConvert.SerializeObject(p), System.Text.Encoding.UTF8, "application/json");

            var post = client.PostAsync(uri, content);
            post.Wait();
            result = post.Result;

            if (result.IsSuccessStatusCode == true)
            {
                return result.IsSuccessStatusCode;
            }
            return false;
        }
    }
}
