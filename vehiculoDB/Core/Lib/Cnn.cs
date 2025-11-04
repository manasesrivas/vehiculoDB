using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace vehiculoDB.Core.Lib
{
    internal class Cnn
    {
        private readonly SqlConnection _conexion;

        public Cnn()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString;
            _conexion = new SqlConnection(connectionString);
        }

        public SqlConnection OpenDb()
        {
            try
            {
                if(_conexion.State == System.Data.ConnectionState.Closed)
                {
                    _conexion.Open();
                }
                return _conexion;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al abrir la conexion a la base de datos: " + ex.Message, "DataBase",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void CloseDb()
        {
            try
            {
                if (_conexion.State != System.Data.ConnectionState.Closed)
                {
                    _conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cerrar la conexion a la base de datos: " + ex.Message, "DataBase",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
