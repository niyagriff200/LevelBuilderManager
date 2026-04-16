using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace LevelBuilderManager.Data
{
    public static class DBHelper
    {
        //Create a variable that will hold the connection string info
        private static string levelBuilderDB = ConfigurationManager.ConnectionStrings["LevelBuilderDB"].ConnectionString;

        //This method will set up the MSSQL connection string for the database and return it as a string
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(levelBuilderDB);
        }

        //Set up a method that will return the Data Table of the specified query
        public static DataTable ExecuteRead(string sql, Dictionary<string, object>parameters)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //Add the parameters to the command
                    AddParameters(cmd, parameters);

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        //This will run INSERT, UPDATE, DELETE
        public static int ExecuteNonQuery(string sql, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    AddParameters(cmd, parameters);

                    // Execute the command and return the number of affected rows
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //This will add the parameters from the user (safely) to the SQL command
        private static void AddParameters(SqlCommand cmd, Dictionary<string, object> parameters)
        {
            if (parameters == null)
            {
                return;
            }

            //Loop through the parameters and add them to the command
            foreach (var param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value); //the ?? operator is used to handle null values by converting them to DBNull.Value,
                                                                                     //which is the appropriate way to represent nulls in SQL parameters
            }
        }
    }
}
