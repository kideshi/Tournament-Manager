using ManagerLibrary.Models;

namespace ManagerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        //TODO: Сделать метод CreatePrize совместимым с текстом.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
