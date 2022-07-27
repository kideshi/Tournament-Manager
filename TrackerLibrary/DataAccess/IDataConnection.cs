using ManagerLibrary.Models;
using System.Collections.Generic;

namespace ManagerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel prize);
        PersonModel CreatePerson(PersonModel person);
        TeamModel CreateTeam(TeamModel team);
        List<PersonModel> GetPersonAll();
        
    }
}
