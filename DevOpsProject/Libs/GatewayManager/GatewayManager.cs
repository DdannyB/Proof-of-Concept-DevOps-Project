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
        public async Task<List<T>> GetlistAsync<T>(string uri)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                var result = await client.SendAsync(request);

                if (result.IsSuccessStatusCode)
                {
                    String responseString = await result.Content.ReadAsStringAsync();
                    var dbpersonlist = JsonConvert.DeserializeObject<List<T>>(responseString);
                    return dbpersonlist;
                }
                return null;
            }
        }

        public async Task<T> GetAsync<T>(string uri, int id)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, uri + id);
                var result = await client.SendAsync(request);

                if (result.IsSuccessStatusCode)
                {
                    String responseString = await result.Content.ReadAsStringAsync();
                    var dbperson = JsonConvert.DeserializeObject<T>(responseString);
                    return dbperson;
                }
                return default(T);
            }
        }


        public async Task<HttpResponseMessage> PostAsync<T>(string uri, T p)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(p), System.Text.Encoding.UTF8, "application/json");
                return await client.PostAsync(uri, content);
            }
        }  
        

        public async Task<HttpResponseMessage> EditAsync<T>(string uri, T p)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(p), System.Text.Encoding.UTF8, "application/json");
                return await client.PutAsync(uri, content);
            }
        }

        public async Task<HttpResponseMessage> DeleteAsync<T>(string uri, T p)
        {
            using (var client = new HttpClient())
            {
                return await client.DeleteAsync(uri);
            }
        }
    }
}
