using System.Collections.Generic;
using System.Linq;
using covidtrackerhnApi.Context;
using covidtrackerhnApi.Domain;

namespace covidtrackerhnApi.Repository
{
    public class CountryRepositoryImpl : ICountryRepository
    {

        private  CovidTrackernHnContext _context;

        public CountryRepositoryImpl(CovidTrackernHnContext context)
        {
            _context=context;
        }
        public Country add(Country country)
        {
            
           _context.Countries.Add(country);

           return country;
        }

        public void delete(Country country)
        {
            throw new System.NotImplementedException();
        }

        public Country Find(string abbreaviation)
        {
            var country=_context.Countries.Where(x=>x.abbreaviation==abbreaviation).SingleOrDefault();

            return country;
        }

        public List<Country> FindAll()
        {
           var countries= _context.Countries.ToList();
           return countries;
        }

        public Country update(Country country)
        {
            throw new System.NotImplementedException();
        }
    }
}