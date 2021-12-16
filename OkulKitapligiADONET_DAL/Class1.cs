using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKitapligiADONET_DAL
{
    public class MyPocketDAL
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        private string _sqlConnectionString;
        public string SQLConnectionString
        {
            get
            {
                return _sqlConnectionString;
            }
        }
        private SqlConnection mySQLConnection = new SqlConnection();
        private SqlCommand mySQLCommand = new SqlCommand();
        private SqlDataAdapter mySQLAdapter = new SqlDataAdapter();
        public MyPocketDAL(string serverName, string dbName, string userID, string password)
        {
            /* MyPocketDAL Class'ından bir nesne türetilirken:
             * SQL Server Name ve Parola alınacak.
             * Alınan değerler bu Class'ın sahip olduğu SQLConnectingString property'sine atanacak.
             * Böylece bu Class, yapacağı tüm SQL işlemlerinde Connection String'i buradan alacak.
             * Bir kez yazarak bu Class'ın birçok metodunda kullanabiliriz. */
            this.ServerName = serverName;
            this.DatabaseName = dbName;
            this.UserID = userID;
            this.Password = password;

            if (string.IsNullOrEmpty(this.ServerName) || string.IsNullOrEmpty(this.DatabaseName))
            {
                throw new Exception("SQLConnection string için Server Name ve Database Name gereklidir.");
            }

            if (string.IsNullOrEmpty(userID) && string.IsNullOrEmpty(password))
            {
                this._sqlConnectionString = "Server=" + this.ServerName + ";Database=" + this.DatabaseName + ";Trusted_Connection=True";
            }
            else if (string.IsNullOrEmpty(this.UserID) && string.IsNullOrEmpty(this.Password))
            {
                this._sqlConnectionString = @"Server=" + this.ServerName + ";Database=" + this.DatabaseName + ";Trusted_Connection=True";

            }
            else
            {
                this._sqlConnectionString = @"Data Source=" + this.ServerName + ";Initial Catalog=" + this.DatabaseName + ";Persist Security Info=True;User ID=" + this.UserID + ";Password=" + this.Password;
            }


        }
        public DataTable GetTheData(string tableName, string fieldName, string condition)
        {
            // retVal ---> returnValue
            DataTable retVal = new DataTable();
            string queryString = "";
            if (string.IsNullOrEmpty(condition))
            {
                queryString = "SELECT " + fieldName + " FROM " + tableName;
            }
            else
            {
                queryString = "SELECT " + fieldName + " FROM " + tableName + " WHERE " + condition;
            }

            using (this.mySQLConnection)
            {
                this.mySQLCommand = new SqlCommand(queryString, this.mySQLConnection);
                OpenTheConnection();
                this.mySQLAdapter = new SqlDataAdapter(this.mySQLCommand);
                this.mySQLAdapter.Fill(retVal);

            }

            


            return retVal;
        }

        public DataTable GetTheData(string query)
        {
            DataTable retVal = new DataTable();

            using (this.mySQLConnection)
            {
                this.mySQLCommand = new SqlCommand(query, this.mySQLConnection);
                OpenTheConnection();
                this.mySQLAdapter = new SqlDataAdapter(this.mySQLCommand);
                this.mySQLAdapter.Fill(retVal);

            }

            return retVal;

        }
        public void OpenTheConnection()
        {
            try
            {
                if (this.mySQLConnection.State!=ConnectionState.Open)
                {
                    this.mySQLConnection.ConnectionString = this.SQLConnectionString;
                    this.mySQLConnection.Open();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CloseTheConnection()
        {
            try
            {
                if (this.mySQLConnection.State != ConnectionState.Closed)
                {
                    this.mySQLConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetTheDataByExecuteScalar(string query)
        {
            object retVal=null;

            using (this.mySQLConnection)
            {
                this.mySQLCommand = new SqlCommand(query, this.mySQLConnection);
                OpenTheConnection();
                retVal = this.mySQLCommand.ExecuteScalar();
            }

            return retVal;
        }
    }
}
