using ManagerLibrary.Models;
using System.Data;
using Dapper;

//@PlaceNumber int,
//@PlaceName nvarchar(50),
//@PrizeAmount money,
//@PrizePercentage float,
//@id int = 0 OUTPUT

namespace ManagerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO: Сделать метод CreatePrize сохранять объект в БД.
        /// <summary>
        /// Сохраняет новый приз в базу данных.
        /// </summary>
        /// <param name="model">Модель приза с информацией о ней.</param>
        /// <returns>Обновленная информация о приза, включая уникальный ID.
        /// </returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("Tournaments")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PlaceNumber", model.PlaceNumber);
                parameters.Add("@PlaceName", model.PlaceName);
                parameters.Add("@PrizeAmount", model.PrizeAmount);
                parameters.Add("@PrizePercentage", model.PrizePercentage);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("@id");

                return model;
            }
        }
    }
}
