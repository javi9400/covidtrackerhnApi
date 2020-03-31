using System;

namespace covidtrackerhnApi.Domain
{
    public class CovidCase
    {
         public int CovidCaseId { get; private set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public int StateId { get; set; }
        public State State { get; set; }

        public int ConfirmedCases { get; set; }

        public int Deaths { get; set; }
        public int Active { get; set; }

        public int Recovered { get; set; }

        public DateTime LastUpdated { get; set; }

        public DateTime CreationDate { get; set; }
    }
}