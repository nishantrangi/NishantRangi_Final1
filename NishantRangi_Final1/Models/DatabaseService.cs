using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NishantRangi_Final1.Models
{
    // Todo: details based on word doc
    public class DatabaseService
    {
        /// <summary>
        /// Database connection string.
        /// </summary>
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        /// <summary>
        /// To get data from database.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataSet GetData(string query)
        {
            try
            {
                if (!string.IsNullOrEmpty(query))
                {
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
                    databaseConnection.Open();
                    DataSet dataSet = new DataSet();
                    mySqlDataAdapter.Fill(dataSet);
                    databaseConnection.Close();
                    return dataSet;
                }
                return null;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// To add or update data in database.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool AddOrUpdateData(string query)
        {
            try
            {
                if (!string.IsNullOrEmpty(query))
                {
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    databaseConnection.Open();
                    var result = commandDatabase.ExecuteScalar();
                    databaseConnection.Close();
                    return true;;
                }
                return false;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
