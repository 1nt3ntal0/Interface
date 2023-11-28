using Interface.controles;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Interface
{
    public class TablasHistorial
    {
        public DataTable ObtenerUltimosRegistros(int idDispositivo)
        {
            Conexion conexion = new Conexion();
            DataTable resultado = new DataTable();

            string query = $"SELECT * FROM LecturasDeSensores WHERE IDDispositivo = {idDispositivo} ORDER BY IDMedicion DESC LIMIT 30;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.GetConexion()))
            {
                adapter.Fill(resultado);
            }
            var datosOrdenados = resultado.AsEnumerable()
                                          .OrderBy(row => row.Field<int>("IDMedicion"))
                                          .CopyToDataTable();

            conexion.CerrarConexion();
            datosOrdenados.DefaultView.AllowDelete = false;
            datosOrdenados.DefaultView.AllowEdit = false;
            datosOrdenados.DefaultView.AllowNew = false;

            return datosOrdenados;
        }
    }
}
