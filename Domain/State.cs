using System;

namespace covidtrackerhnApi.Domain
{
    public class State
    {
        
        public int StateId { get; private set; }
        public string Name { get; set; }

        public string Abbreaviation{get;set;}
        public int CountryId{get;set;}
        public Country Country{ get; set; }
        
        public DateTime CreationDate { get; set; }

        
    }
}