using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystemLibrary.DataAccess;

namespace ExaminationSystemLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(string connectionType)
        {
            if(connectionType == "sql")
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if(connectionType == "text")
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
