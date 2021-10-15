using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
   public class SqlDbHelper
    {
        private SqlConnection sqlConnection;
        public SqlDbHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int ExecuteCommand(string commandText,Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = createCommand(commandText, parameters);           
            sqlCommand.Connection.Open();
            var affectedRow = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();

            return affectedRow;



        }

        private SqlCommand createCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = commandText;
            sqlCommand.Connection = sqlConnection;
            AddParametersToCommand(parameters, sqlCommand);
            return sqlCommand;

        }

        private  void AddParametersToCommand(Dictionary<string, object> parameters, SqlCommand sqlCommand)
        {
            foreach (var param in parameters)
            {
                sqlCommand.Parameters.AddWithValue(param.Key, param.Value);
            }
        }
    }
}
