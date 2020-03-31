using System.Collections.Generic;
using covidtrackerhnApi.Domain;

namespace covidtrackerhnApi.Service.CovidCases
{
    public interface ICovidCaseService
    {
        List<CovidCase> GetAllCovidCasesBy(Country country);
        List<CovidCase> GetAllCovidCasesBy(State country);
        CovidCase GetMaxCovidCaseBy(Country country);
    }
}