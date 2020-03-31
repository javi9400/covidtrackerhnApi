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
    }
}