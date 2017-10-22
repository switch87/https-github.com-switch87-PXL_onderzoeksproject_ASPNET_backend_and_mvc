using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using MvcApplication.Factories;
using MvcApplication.Models;

namespace MvcApplication
{
    public class PersonsService
    {
        private static readonly PersonsFactory factory = new PersonsFactory();
        private static readonly PersonImagesFactory imageFactory = new PersonImagesFactory();

        public List<Person> getAllPersons()
        {
            return factory.persons;
        }

        public Person getPerson(int id)
        {
            return factory.persons.FirstOrDefault(person => person.Id == id);
        }

        public string getPersonImage(int id)
        {
            PersonImage personImage = imageFactory.personImages.FirstOrDefault(image => image.personId == id);
            return Base64Service.ImageToBase64(personImage.Image);
        }
    }
}