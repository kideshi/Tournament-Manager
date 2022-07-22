using System.Collections.Generic;
using ManagerLibrary.DataAccess;

namespace ManagerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO: Реализовать SqlConnector более здраво.
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                // TODO: Make the text connection.
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
