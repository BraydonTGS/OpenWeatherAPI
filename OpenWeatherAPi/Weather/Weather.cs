using System;
using Newtonsoft.Json.Linq;

namespace OpenWeatherAPi.Weather
{
    public class Weather
    {
        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();

            var response = client.GetStringAsync(apiCall).Result;

            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            return temp;

        }

        public static string GetName(string apiCall)
        {
            var client = new HttpClient();

            var response = client.GetStringAsync(apiCall).Result;

            var name = JObject.Parse(response)["name"].ToString();

            return name;
        }

        public static string GetWeather(string apiCall)
        {
            var client = new HttpClient();

            var response = client.GetStringAsync(apiCall).Result;

            var weather = JObject.Parse(response)["weather"][0]["main"].ToString();

            return weather;
        }
    }
}

