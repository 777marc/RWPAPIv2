using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RWPAPIv2.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace RWPAPIv2.Services
{
    public class WeatherService
    {

        public Weather.MasterWeather GetWeather(float lat, float lon)
        {
            Weather.MasterWeather newWeather = new Weather.MasterWeather();
            
            // Create a request for the URL. 
            WebRequest request = WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?lat=35&lon=139");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams and the response.
            reader.Close();
            response.Close();

            JObject callResults = JObject.Parse(responseFromServer);
            newWeather = JsonConvert.DeserializeObject<Weather.MasterWeather>(responseFromServer);
                        
            return newWeather;
        }

    }
}