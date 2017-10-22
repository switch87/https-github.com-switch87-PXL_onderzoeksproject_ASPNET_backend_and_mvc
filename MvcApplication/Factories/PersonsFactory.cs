using System;
using System.Collections.Generic;
using System.IO;
using MvcApplication.Models;
using Newtonsoft.Json;

namespace MvcApplication.Factories
{
    public class PersonsFactory
    {
        public PersonsFactory()
        {
            using (StreamReader jsonFile = File.OpenText("data/persons.json"))
            {
                string json = jsonFile.ReadToEnd();
                this.persons = JsonConvert.DeserializeObject<List<Person>>(json);
            }
        }

        public List<Person> persons { get; set; }
    }
}