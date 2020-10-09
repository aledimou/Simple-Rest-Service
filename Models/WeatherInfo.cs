using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestDemo.Models
{
    [DataContract]
    public class WeatherInfo
    {
        [DataMember(Name = "Location")]
        public string Location { get; set; }
        [DataMember(Name = "degree")]
        public double Degree { get; set; }
        [DataMember(Name = "Datetime")]
        public DateTime DateTime { get; set; }
    }
}