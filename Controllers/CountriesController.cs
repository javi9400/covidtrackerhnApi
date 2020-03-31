using System.Collections.Generic;
using covidtrackerhnApi.Domain;
using covidtrackerhnApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace covidtrackerhnApi.Controllers
{

     [ApiController]
    [Route("[controller]")]
     public class CountriesController:ControllerBase
    {
        private readonly ICountryRepository _repo;

        public CountriesController()
        {
            _repo=new CountryRepositoryImpl();
        }
        
         [HttpGet]
         public IList<Country> FindAll()
         {

             var countries= _repo.FindAll();

             return countries;

         }


          [HttpGet("{abbreviation}")]
         public Country Find(string abbreviation)
         {

             var country= _repo.Find(abbreviation);

             return country;

         }

          [HttpPost]
         public ActionResult<Country> Add(Country country)
         {

             var addedCountry= _repo.add(country);

           return addedCountry;

         }
    }
}