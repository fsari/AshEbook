using System.Net.Http;

namespace AshEbook.Helpers
{
    public class GeoHelper
    { 
        const string GeoIpUrl = "http://freegeoip.net/json/{0}";
        private readonly string _ipAddress = string.Empty;
        
        public GeoHelper(string ip)
        {
            _ipAddress = ip;
        }

        public string GetGeoAsync()
        {
            string uri = string.Format(GeoIpUrl, _ipAddress);

            var httpClient = new HttpClient();

            var response = httpClient.GetAsync(uri);
             

            return response.Result.Content.ReadAsStringAsync().Result;
        }

    }
}