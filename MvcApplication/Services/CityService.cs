using System.Collections.Generic;
using System.Linq;
using MvcApplication.Factories;
using MvcApplication.Models;

namespace MvcApplication
{
    public class CityService
    {
        private static CityFactory factory = new CityFactory();

        public List<CityModel> getAllCities()
        {
            return factory.zipcodes;
        }

        public List<CityModel> getCitiesByZipcodeBeginsWith(string zipcodePartial)
        {
            return factory.zipcodes.Where(zc => zc.Zip.StartsWith(zipcodePartial)).ToList();
        }
    }
}