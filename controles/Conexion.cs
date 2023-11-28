using MySql.Data.MySqlClient;
using System;

namespace Interface.controles
{
    public class Conexion
    {
        private Actualizacion actualizacion;
        private MySqlConnection conexion;
        private string server = "srv1064.hstgr.io";
        private string user = "u454094502_mimi666";
        private string pwd = "85AGBqjFeDh/";
        private string databases = "u454094502_proyectred";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Server=" + server + ";user=" + user + "; password= " + pwd + ";Database=" + databases + ";Port=3306";
        }

        public MySqlConnection GetConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            return conexion;
        }
        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        public string ObtenerCadenaConexion()
        {
            return cadenaConexion;
        }
    }
}
