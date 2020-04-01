using System.Collections.Generic;
using covidtrackerhnApi.Domain;
using covidtrackerhnApi.Repository;
using Microsoft.AspNetCore.Mvc;
using covidtrackerhnApi.Context;
using covidtrackerhnApi.Service.Countries;

namespace covidtrackerhnApi.Controllers
{

     [ApiController]
    [Route("[controller]")]
     public class CountriesController:ControllerBase
    {
        private readonly ICountryService _service;

        public CountriesController(CovidTrackernHnContext context )
        {
            _service=new CountryServiceImplm(context);
            
        }
        
         [HttpGet]
         public IList<Country> FindAll()
         {

             var countries= _service.FindAll();

             return countries;

         }


          [HttpGet("{abbreviation}")]
         public Country Find(string abbreviation)
         {

             var country= _service.Find(abbreviation);

             return country;

         }

          [HttpPost]
         public ActionResult<Country> Add(Country country)
         {

             var addedCountry= _service.add(country);

           return addedCountry;

         }
    }
}