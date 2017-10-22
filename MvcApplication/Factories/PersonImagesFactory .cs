using System;
using System.Collections.Generic;
using System.IO;
using MvcApplication.Models;
using Newtonsoft.Json;

namespace MvcApplication.Factories
{
    public class PersonImagesFactory
    {
        public PersonImagesFactory()
        {
            using (StreamReader jsonFile = File.OpenText("data/personImages.json"))
            {
                string json = jsonFile.ReadToEnd();
                this.personImages = JsonConvert.DeserializeObject<List<PersonImage>>(json);
            }
        }

        public List<PersonImage> personImages { get; set; }
    }
}