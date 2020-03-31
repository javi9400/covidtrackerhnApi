using System.Collections.Generic;
using covidtrackerhnApi.Domain;

namespace covidtrackerhnApi.Repository
{
    public interface ICovidCaseRepository
    {
        List<CovidCase> GetAllCovidCasesBy(Country country);
        List<CovidCase> GetAllCovidCasesBy(State country);
        CovidCase GetMaxCovidCaseBy(Country country);
    }
}