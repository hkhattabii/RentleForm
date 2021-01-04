using Newtonsoft.Json;
using RentleForm.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RentleForm
{
    public static class Utils
    {
        private static readonly HttpClient client = new HttpClient();
        private static Dictionary<string, object> dic;
        public static async Task<APIRes> Post(string uri, string body)
        {
            HttpContent data = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(uri, data);
            Console.WriteLine("RESPONSE :" + response);
            string responseString = await response.Content.ReadAsStringAsync();
            APIRes entity = JsonConvert.DeserializeObject<APIRes>(responseString);
            return entity;
        }

        public static async Task<List<TEntity>> Get<TEntity>(string uri)
        {
            HttpResponseMessage response = await client.GetAsync(uri);
            string responseString = await response.Content.ReadAsStringAsync();
            List<TEntity> entities =  JsonConvert.DeserializeObject<List<TEntity>>(responseString);
            return entities;
        }

        public static Dictionary<string, object> ToDictionnary(object entity)
        {
            return entity.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                   .ToDictionary(prop => prop.Name, prop => prop.GetValue(entity, null));
        }

        public static string ToJson(object entityDic)
        {
            return JsonConvert.SerializeObject(entityDic);
        }

    }
}
