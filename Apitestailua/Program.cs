using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Text.Json;


namespace Apitestailua
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "http://open-api.myhelsinki.fi/v2/places/";

            try
            {
                using (var client = APIHelper.GetHttpClient(url))
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        

                        V2Places results = JsonSerializer.Deserialize<V2Places>(json);

                        foreach (var item in results.data)
                        {
                            Console.WriteLine("ID: " + item.id + " Name: " + item.name.fi);
                        }

                        Console.WriteLine($"Found {results.meta.count} items.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
