using Interface.controles;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interface
{
    public partial class Historial : Form
    {
        private TablasHistorial tablasHistorial;

        public Historial(int idDispositivo)
        {
            InitializeComponent();
            this.tablasHistorial = new TablasHistorial();
            MostrarUltimosRegistros(idDispositivo);

            // Manejar el evento FormClosing
            this.FormClosing += Historial_FormClosing;
        }

        public void MostrarUltimosRegistros(int idDispositivo)
        {
            DataTable datos = tablasHistorial.ObtenerUltimosRegistros(idDispositivo);

            if (dataGridView1.Columns.Contains("IDDispositivo"))
            {
                dataGridView1.Columns.Remove("IDDispositivo");
            }

            MostrarDatosEnGrid(datos);
        }

        private void MostrarDatosEnGrid(DataTable datos)
        {
            dataGridView1.DataSource = datos;
        }

        private void Historial_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
