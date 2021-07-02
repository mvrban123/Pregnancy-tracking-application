using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using Npgsql;
using System.Windows.Forms;

namespace PreganancyApp
{
    class dbConnect
    {
        private static dbConnect instance;

        public static dbConnect Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new dbConnect();
                }
                return instance;
            }
        }

        public string ConnectionString { get; private set; }

        public NpgsqlConnection Connection { get; private set; }

        private dbConnect()
        {
            ConnectionString = "Host=localhost;Username=postgres;Password=5225;Database=PregnancyTrackingApp";
            Connection = new NpgsqlConnection(ConnectionString);
            Connection.Open();
        }

        public void CloseConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        public NpgsqlDataReader DohvatiDataReader(string sqlUpit)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sqlUpit, Connection);
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sqlUpit, Connection);
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sqlUpit, Connection);
                return command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}

