using System;
using System.Collections.Generic;
using System.IO;
using MvcApplication.Models;
using Newtonsoft.Json;

namespace MvcApplication.Factories
{
    public class CityFactory
    {
        public CityFactory()
        {
            using (StreamReader jsonFile = File.OpenText("data/zipcode-belgium/zipcode-belgium.json"))
            {
                string json = jsonFile.ReadToEnd();
                this.zipcodes = JsonConvert.DeserializeObject<List<CityModel>>(json);
            }
        }

        public List<CityModel> zipcodes { get; set; }
    }
}