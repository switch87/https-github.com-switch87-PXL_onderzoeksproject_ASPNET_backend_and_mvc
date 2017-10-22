using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        private CityService _service = new CityService();
        
        // GET api/city
        [HttpGet]
        public IEnumerable<CityModel> Get()
        {
            return _service.getAllCities();
        }
        
        // GET api/city/[partial zipcode]
        [HttpGet("partialzipcode/{partialZipcode}")]
        public IEnumerable<CityModel> Get(int partialZipcode)
        {
            return _service.getCitiesByZipcodeBeginsWith(partialZipcode.ToString());
        }
        
    }
}