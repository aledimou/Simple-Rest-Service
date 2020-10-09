using RestDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestDemo.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<WeatherInfo> Get()
        {
                 
            try
            {
                var WeatherInfoList = new List<WeatherInfo>(); 
                string[] City = new string[] { "London", "Paris", "Athens", "New York", "Berlin", "Vienna", "Moscow", "Tel-Aviv", "Zagreb", "Warsaw" };

                for (int i = 0; i < City.Length; i++)
                {
                    var weatherInfo = new WeatherInfo
                    {

                        Location = City[i],
                        Degree = 20 + 17 / 2 * i,
                        DateTime = DateTime.Now.ToUniversalTime()

                    };
                    WeatherInfoList.Add(weatherInfo);
                }
                return WeatherInfoList;
            }
            catch (Exception ex)
            {

                throw;
            }
            

        }
        // GET: api/Weather/5
        public WeatherInfo Get(int id)
        {
            return new WeatherInfo
            {
                Location = ("Location " + id),
                Degree = 20 + 17 / 2 * id,
                DateTime = DateTime.Now.ToUniversalTime()
            };

        }
    }
}
