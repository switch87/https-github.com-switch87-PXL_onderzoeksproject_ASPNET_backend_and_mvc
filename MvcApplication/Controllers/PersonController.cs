using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcApplication;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private PersonsService ps = new PersonsService();

        // GET api/person
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return ps.getAllPersons();
        }

        // GET api/person/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return ps.getPerson(id);
        }
        
        // GET api/person/5/image
        [HttpGet("{id}/image")]
        public String GetImage(int id)
        {
            return ps.getPersonImage(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}