using System;

namespace covidtrackerhnApi.Domain
{
    public class Country
    {
       
        public Country(int id)
        {
        }

        public Country(string name, DateTime creationDate)
        {
            this.Name=name;
            this.CreationDate=creationDate;
        }
        public int CountryId { get; private set; }
        public string Name { get; set; }

        public string abbreaviation { get; private set; }

        public DateTime CreationDate { get; set; }

        public int isActive {get;set;}
    }
}