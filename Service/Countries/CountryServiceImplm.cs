using System.Collections.Generic;
using covidtrackerhnApi.Domain;
using covidtrackerhnApi.Repository;

namespace covidtrackerhnApi.Service.Countries
{
    public class CountryServiceImplm : ICountryService
    {

        private ICountryRepository _repo;

        public CountryServiceImplm()
        {
            _repo=new CountryRepositoryImpl();
        }
        public Country add(Country country)
        {
           _repo.add(country);

           return country;
        }

        public void delete(Country country)
        {
            throw new System.NotImplementedException();
        }

        public Country Find(string abbreaviation)
        {
           return  _repo.Find(abbreaviation);
        }

        public List<Country> FindAll()
        {
           return _repo.FindAll();
        }

        public Country update(Country country)
        {
            throw new System.NotImplementedException();
        }
    }
}