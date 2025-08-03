using MVC_project__curd_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVC_project__curd_.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult Weather()
        {

            return View();
        }
        [HttpPost]
        public String WeatherDetail(string City)
        {

            string appId = "8113fcc5a7494b0518bd91ef3acc074f";

            string url =
           string.Format("http://api.openweathermap.org/data/2.5/weather?q={1}&units=metric&cnt=1&1&APPID={1}\r\n\",City,appId");

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                RootObject weatherInfo = (new
               JavaScriptSerializer()).Deserialize<RootObject>(json);
                Weathermodel rslt = new Weathermodel();
                rslt.Country = weatherInfo.sys.country;
                rslt.City = weatherInfo.name;
                rslt.Lat = Convert.ToString(weatherInfo.coord.lat);
                rslt.Lon = Convert.ToString(weatherInfo.coord.lon);
                rslt.Description = weatherInfo.weather[0].description;
                rslt.Humidity = Convert.ToString(weatherInfo.main.humidity);
                rslt.Temp = Convert.ToString(weatherInfo.main.temp);
                rslt.TempFeelsLike = Convert.ToString(weatherInfo.main.feels_like);
                rslt.TempMax = Convert.ToString(weatherInfo.main.temp_max);
                rslt.TempMin = Convert.ToString(weatherInfo.main.temp_min);
                rslt.WeatherIcon = weatherInfo.weather[0].icon;
                var jsonstring = new JavaScriptSerializer().Serialize(rslt);

                return jsonstring;


            }
        }
    }
}
