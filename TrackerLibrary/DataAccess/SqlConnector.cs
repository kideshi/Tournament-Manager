using System.Collections.Generic;
using System.Linq;
using ManagerLibrary.Models;
using System.Data;
using Dapper;

namespace ManagerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string dbName = "Tournaments";

        /// <summary>
        /// Сохраняет новый приз в базу данных.
        /// </summary>
        /// <param name="model">Модель приза с информацией о ней.</param>
        /// <returns>Обновленная информация о приза, включая уникальный ID.
        /// </returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(dbName)))
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

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", model.FirstName);
                parameters.Add("@LastName", model.LastName);
                parameters.Add("@EmailAddress", model.EmailAddress);
                parameters.Add("@PhoneNumber", model.PhoneNumber);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("@id");

                return model;
            }
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@TeamName", model.TeamName);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("@id");

                foreach (PersonModel teamMember in model.TeamMembers)
                {
                    parameters = new DynamicParameters();
                    parameters.Add("@TeamId", model.Id);
                    parameters.Add("@PersonId", teamMember.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", parameters, commandType: CommandType.StoredProcedure);
                }

                return model;
            }
        }

        public List<PersonModel> GetPersonAll()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(dbName)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }

        public List<TeamModel> GetTeamAll()
        {
            List<TeamModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(dbName)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@TeamId", team.Id);

                    team.TeamMembers = connection.Query<PersonModel>(
                                                                    "dbo.spTeamMembers_GetByTeam", 
                                                                    parameters, 
                                                                    commandType: CommandType.StoredProcedure
                                                                    ).ToList();
                }
            }

            return output;
        }
    }
}
