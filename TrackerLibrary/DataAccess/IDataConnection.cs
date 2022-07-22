using ManagerLibrary.Models;

namespace ManagerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel prize);
    }
}
