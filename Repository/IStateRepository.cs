using System.Collections.Generic;
using covidtrackerhnApi.Domain;

namespace covidtrackerhnApi.Repository
{
    public interface IStateRepository
    {
      State Find(State state);
      List<State> FindAll(Country country);

      State Add(State state);
      
      State Update(State  state);

      void Delete(int state);
    }
}