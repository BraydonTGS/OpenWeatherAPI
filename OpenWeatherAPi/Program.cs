using Newtonsoft.Json.Linq;
using OpenWeatherAPi.Weather;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

//Getting all of the information from appsettings // 
string key = File.ReadAllText("appsettings.json");

//Parsing For the Value of APIKEY //
string APIKey = JObject.Parse(key).GetValue("APIKEY").ToString();

Console.Write("Please Enter a City Name: ");
var cityName = Console.ReadLine().ToLower().Trim();

var apiString = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={APIKey}&units=imperial";

var name = Weather.GetName(apiString);
var temp = Weather.GetTemp(apiString);
var weather = Weather.GetWeather(apiString);

Console.WriteLine($"The City of {cityName} has a current temperature of {temp} with {weather}");
Console.ReadKey();