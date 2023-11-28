using MySql.Data.MySqlClient;
using System;
using System.Text;
using System.Threading;

namespace Interface.controles
{
    public class Actualizacion
    {
        public event EventHandler NVChanged;

        private int nv;

        public int NV
        {
            get => nv;
            set
            {
                if (nv != value)
                {
                    nv = value;
                    OnNVChanged();
                }
            }
        }

        protected virtual void OnNVChanged()
        {
            NVChanged?.Invoke(this, EventArgs.Empty);
        }

        private Conexion sqlConexion;
        public double[,] Sensores { get; private set; }
        public string ERRORLECTURAS { get; set; }
        public string Alertas { get; set; }

        public Actualizacion(Conexion conexion)
        {
            sqlConexion = conexion;
            Sensores = new double[5, 2];
        }

        public void IniciarBucleInfinito()
        {
            while (true)
            {
                ActualizarValores();
                Thread.Sleep(TimeSpan.FromSeconds(3));
            }
        }

        public void ActualizarValores()
        {
            int totalHabitacionesPorPiso = 5;

            for (int piso = 1; piso <= 2; piso++)
            {
                for (int habitacion = 1; habitacion <= totalHabitacionesPorPiso; habitacion++)
                {
                    int habitacionEnPiso = (habitacion - 1) % totalHabitacionesPorPiso + 1;

                    Sensores[habitacion - 1, piso - 1] = ObtenerNuevoValor(habitacionEnPiso + (piso - 1) * totalHabitacionesPorPiso);
                }
            }

            RevisarAlertas();
        }

        private double ObtenerNuevoValor(int idDispositivo)
        {
            double nuevoValor = 0.0;

            if (idDispositivo > 0)
            {
                string query = $"SELECT ValorSensorGas FROM LecturasDeSensores WHERE IDDispositivo = {idDispositivo} ORDER BY FechaHora DESC LIMIT 1;";

                using (MySqlConnection connection = new MySqlConnection(sqlConexion.ObtenerCadenaConexion()))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nuevoValor = reader.GetDouble(0);
                            }
                        }
                    }
                }
            }

            return nuevoValor;
        }

        public void RevisarAlertas()
        {
            StringBuilder mensajeError = new StringBuilder("Lecturas erróneas de sensores:");
            StringBuilder alertas = new StringBuilder("Alertas en los sensores:");

            for (int piso = 1; piso <= 2; piso++)
            {
                for (int habitacion = 1; habitacion <= 5; habitacion++)
                {
                    double lectura = Sensores[habitacion - 1, piso - 1];

                    if (EsLecturaErronea(lectura))
                    {
                        if (habitacion == 5 && piso == 1)
                        {
                        }
                        else
                        {
                            mensajeError.AppendLine($"EN LA HABITACION {habitacion} DEL PISO {piso} SENSOR FUERA DE RANGO.");
                        }
                    }
                    if (lectura > 150 && lectura < 1000)
                    {
                        alertas.AppendLine($"EN LA HABITACION {habitacion} DEL PISO {piso} SENSOR CON LECTURA ANORMAL.");
                    }
                }
            }

            ERRORLECTURAS = mensajeError.ToString();
            Alertas = alertas.ToString();

            MostrarMensajeError(ERRORLECTURAS);
            MostrarMensajeAlerta(Alertas);
        }

        public bool EsLecturaErronea(double lectura)
        {
            return lectura < 10 || lectura > 1000;
        }

        private void MostrarMensajeError(string mensaje)
        {
        }

        private void MostrarMensajeAlerta(string mensaje)
        {
        }
    }
}
