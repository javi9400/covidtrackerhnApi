using System.Collections.Generic;
using covidtrackerhnApi.Domain;

namespace covidtrackerhnApi.Service.Countries
{
    public interface ICountryService
    {
        Country Find(string abbreaviation);
        List<Country> FindAll();

        Country add(Country country);
      
        Country update(Country country);

        void delete(Country country);
    }
}