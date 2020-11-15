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
        public static async void Post(Dictionary<string, string> body)
        {
            FormUrlEncodedContent data = new FormUrlEncodedContent(body);
            HttpResponseMessage response = await client.PostAsync(@"http://localhost:5000/api/guarantors", data);
            string responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);
        }

        public static Dictionary<string, object> ToDictionnary(object entity)
        {
            return entity.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                   .ToDictionary(prop => prop.Name, prop => prop.GetValue(entity, null));
        }

    }
}
