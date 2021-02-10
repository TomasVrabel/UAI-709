using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace RestApi.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var url = "http://localhost:5000/api/hello/Jan";

            
            HttpClient client = new HttpClient();
            var result = client.GetStringAsync(url).Result;
 
            Console.WriteLine(result);
            */

            PostDemo();
        }

        static void PostDemo()
        {
            HttpClient client = new HttpClient();

            var json = "{ \"name\": \"Michal\" }";
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync("http://localhost:5000/api/Hello/ping", data).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            
            Console.WriteLine(result);
        }
    }
}
