using System.Collections.Generic;
using System.Configuration;
using ManagerLibrary.DataAccess;

namespace ManagerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType databaseType)
        {
            if (databaseType == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (databaseType == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        /// <summary>
        /// Возвращает строку подключения к серверу БД.
        /// </summary>
        /// <param name="name">Название БД, строку подключения которой необходимо получить.</param>
        /// <returns>Строка подключения.</returns>
        public static string ConString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
