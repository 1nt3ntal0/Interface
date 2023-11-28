using System;
using System.IO.Ports;
using Interface.controles;
using MySql.Data.MySqlClient;

namespace TuNombreDelProyecto
{
    class SubirDatos
    {
        private Conexion sqlConexion;
        private SerialPort serialPort;

        public SubirDatos()
        {
            // Crear una instancia de la clase Conexion para manejar la conexión a la base de datos
            sqlConexion = new Conexion();

            // Puerto serial
            string puertoSerial = "COM11";  // Ajusta el puerto serial según tu configuración
            serialPort = new SerialPort(puertoSerial, 9600);
        }

        public void Ejecutar()
        {
            try
            {
                serialPort.Open();

                while (true)
                {
                    string data = serialPort.ReadLine();

                    string[] partes = data.Split(',');

                    if (partes.Length == 3)
                    {
                        int idDispositivo = Convert.ToInt32(partes[2]);  // Cambié el índice para que coincida con el formato "FechaHora, Medicion, ID"
                        int medicion = Convert.ToInt32(partes[1]);

                        // Llamada al procedimiento almacenado
                        using (MySqlConnection connection = sqlConexion.GetConexion())
                        {
                            using (MySqlCommand cmd = new MySqlCommand("InsertarLectura", connection))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@p_idDispositivo", idDispositivo);
                                cmd.Parameters.AddWithValue("@p_fechaHora", DateTime.Now);
                                cmd.Parameters.AddWithValue("@p_medicion", medicion);

                                var result = cmd.ExecuteScalar();

                                Console.WriteLine(result);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                serialPort.Close();
                // Cerrar la conexión después de su uso
                sqlConexion.CerrarConexion();
            }
        }

        static void MainSubirDatos()
        {
            // Crear una instancia de SubirDatos y ejecutar el método Ejecutar
            SubirDatos subirDatos = new SubirDatos();
            subirDatos.Ejecutar();
        }
    }
}
