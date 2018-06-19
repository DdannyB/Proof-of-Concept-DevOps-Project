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
        public async Task<List<DataBasePerson>> GetPersonlistAsync(string uri)
        {
            using (var client = new HttpClient())
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

        public async Task<DataBasePerson> GetPersonAsync(string uri, int id)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, uri + id);
                var result = await client.SendAsync(request);

                if (result.IsSuccessStatusCode)
                {
                    String responseString = await result.Content.ReadAsStringAsync();
                    var dbperson = JsonConvert.DeserializeObject<DataBasePerson>(responseString);
                    return dbperson;
                }
                return null;
            }
        }


        public async Task<HttpResponseMessage> PostPersonAsync(string uri, DataBasePerson p)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(p), System.Text.Encoding.UTF8, "application/json");
                return await client.PostAsync(uri, content);
            }
        }  
        

        public async Task<HttpResponseMessage> EditPersonAsync(string uri, DataBasePerson p)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(p), System.Text.Encoding.UTF8, "application/json");
                return await client.PutAsync(uri + p.Id, content);
            }
        }

        public async Task<HttpResponseMessage> DeletePersonAsync(string uri, DataBasePerson p)
        {
            using (var client = new HttpClient())
            {
                return await client.DeleteAsync(uri + p.Id);
            }
        }
    }
}
