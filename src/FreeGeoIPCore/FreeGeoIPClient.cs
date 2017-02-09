using FreeGeoIPCore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FreeGeoIPCore
{
    public class FreeGeoIPClient
    {
        public async Task<Location> GetLocation(string ipAddress)
        {
            string url = "https://freegeoip.net/json/";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(new Uri(url));

                response.EnsureSuccessStatusCode();
                Location location = JsonConvert.DeserializeObject<Location>(await response.Content.ReadAsStringAsync());

                return location;
            }
        }
    }
}
