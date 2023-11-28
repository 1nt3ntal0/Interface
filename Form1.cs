using System;
using System.Windows.Forms;
using Interface.controles;
using MySql.Data.MySqlClient;

namespace Interface
{
    public partial class Form1 : Form
    {
        private MiTiempo tiempo;
        private Actualizacion actualizacion;
        private Conexion Sqlconexion;
        private Ping ping;
        private bool estaConectado = false;
        public string[] nombresImagenes = { "NotificacionVisual0", "NotificacionVisual1", "NotificacionVisual2", "NotificacionVisual3", "NotificacionVisual4" };





        public Form1()
        {
            InitializeComponent();
            Sqlconexion = new Conexion();
            ping = new Ping();
            tiempo = new MiTiempo();
            actualizacion = new Actualizacion(Sqlconexion);
            tiempo.InicioTiempo += ActualizacionAlInicio;
            tiempo.IntervaloTranscurrido += ActualizacionEnIntervalo;
        }

        private void onOff1_CheckedChanged(object sender, EventArgs e)
        {
            if (onOff1.Checked)
            {
                try
                {
                    using (MySqlConnection connection = Sqlconexion.GetConexion())
                    {
                        if (connection != null)
                        {
                            MessageBox.Show("Conectado al servidor.");
                            estaConectado = true;
                            button1.Text = "Conectado";
                            pictureBox3.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(nombresImagenes[4]);
                        }
                        else
                        {
                            MessageBox.Show("Error al conectar");
                            onOff1.Checked = false;
                            button1.Text = "Desconectado";
                            estaConectado = false;
                            pictureBox3.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(nombresImagenes[2]);
                        }

                        ActualizarVisibilidadTextBox();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Se ha producido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estaConectado = false;
                    onOff1.Checked = false;
                    button1.Text = "Desconectado";
                    ActualizarVisibilidadTextBox();
                    pictureBox3.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(nombresImagenes[2]);
                }
            }
            else
            {
                // Desconectar
                MessageBox.Show("Desconectado del servidor.");
                estaConectado = false;
                button1.Text = "Desconectado";
                ActualizarVisibilidadTextBox();
            }
        }

        private void ActualizarVisibilidadTextBox()
        {
            bool mostrarDetalles = estaConectado && !textBox20.Visible;
            textBox12.Visible = mostrarDetalles;
            textBox14.Visible = mostrarDetalles;
        }

        private void ActualizacionAlInicio(object sender, EventArgs e)
        {
            while (!ConexionDisponible())
            {
            }

            if (estaConectado)
            {
                actualizacion.ActualizarValores();
            }
        }

        private bool ConexionDisponible()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Sqlconexion.ObtenerCadenaConexion()))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void ActualizacionEnIntervalo(object sender, EventArgs e)
        {
            while (!ConexionDisponible())
            {
            }

            actualizacion.ActualizarValores();

            textBox13.Text = actualizacion.Sensores[0, 0].ToString();
            textBox15.Text = actualizacion.Sensores[1, 0].ToString();
            textBox16.Text = actualizacion.Sensores[2, 0].ToString();
            textBox18.Text = actualizacion.Sensores[3, 0].ToString();
            textBox17.Text = actualizacion.Sensores[0, 1].ToString();
            textBox22.Text = actualizacion.Sensores[1, 1].ToString();
            textBox21.Text = actualizacion.Sensores[2, 1].ToString();
            textBox19.Text = actualizacion.Sensores[3, 1].ToString();
            textBox20.Text = actualizacion.Sensores[4, 1].ToString();
            textBox12.Text = actualizacion.Alertas.ToString();
            textBox14.Text = actualizacion.ERRORLECTURAS.ToString();
        }

        private static void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void primerPisoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cocinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            ping.ShowDialog();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onOff1.Checked)
            {
                MessageBox.Show("Conectado.");
            }
            else
            {
                MessageBox.Show("Desconectado.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip6_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip8_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip9_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
        }
        private int ObtenerIndiceImagen(int valorNV)
        {
            return valorNV % nombresImagenes.Length;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void salaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void VerOcultarDetalles(ToolStripMenuItem menuItem, TextBox textBox)
        {
            if (estaConectado)
            {
                textBox.Visible = !textBox.Visible;
                menuItem.Text = textBox.Visible ? $"Ocultar Detalles" : $"Ver Detalles";
            }
            else
            {
                MessageBox.Show("Debes estar conectado para acceder a esta funcionalidad.");
            }
        }

        private void verDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerOcultarDetalles(verDetallesToolStripMenuItem, textBox13);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VerOcultarDetalles(toolStripMenuItem2, textBox15);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            VerOcultarDetalles(toolStripMenuItem11, textBox16);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            VerOcultarDetalles(toolStripMenuItem8, textBox18);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            VerOcultarDetalles(toolStripMenuItem5, textBox17);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            VerOcultarDetalles(toolStripMenuItem14, textBox22);
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            VerOcultarDetalles(toolStripMenuItem20, textBox21);
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            VerOcultarDetalles(toolStripMenuItem23, textBox19);
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            VerOcultarDetalles(toolStripMenuItem26, textBox20);
        }

        private void verHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!estaConectado)
            {
                MessageBox.Show("Debes estar conectado para acceder a esta funcionalidad.");
                return;
            }
            int idDispositivo = 1;
            Historial historialForm = new Historial(idDispositivo);
            historialForm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!estaConectado)
            {
                MessageBox.Show("Debes estar conectado para acceder a esta funcionalidad.");
                return; 
            }
            int idDispositivo = 2;
            Historial historialForm = new Historial(idDispositivo);
            historialForm.Show();

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (!estaConectado)
            {
                MessageBox.Show("Debes estar conectado para acceder a esta funcionalidad.");
                return; 
            }
            int idDispositivo = 3;
            Historial historialForm = new Historial(idDispositivo);
            historialForm.Show();

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (!estaConectado)
            {
                MessageBox.Show("Debes estar conectado para acceder a esta funcionalidad.");
                return; 
            }
            int idDispositivo = 4;
            Historial historialForm = new Historial(idDispositivo);
            historialForm.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (!estaConectado)
            {
                MessageBox.Show("Debes estar conectado para acceder a esta funcionalidad.");
                return;
            }
            int idDispositivo = 5;
            Historial historialForm = new Historial(idDispositivo);
            historialForm.Show();

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            if (!estaConectado)
            {
                MessageBox.Show("Debes estar conectado para acceder a esta funcionalidad.");
                return;
            }
            int idDispositivo = 6;
            Historial historialForm = new Historial(idDispositivo);
            historialForm.Show();

        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            if (!estaConectado)
            {
                MessageBox.Show("Debes estar conectado para acceder a esta funcionalidad.");
                return;
            }
            int idDispositivo = 7;
            Historial historialForm = new Historial(idDispositivo);
            historialForm.Show();

        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            if (!estaConectado)
            {
                MessageBox.Show("Debes estar conectado para acceder a esta funcionalidad.");
                return;
            }
            int idDispositivo = 8;
            Historial historialForm = new Historial(idDispositivo);
            historialForm.Show();

        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            if (!estaConectado)
            {
                MessageBox.Show("Debes estar conectado para acceder a esta funcionalidad.");
                return;
            }
            int idDispositivo = 9;
            Historial historialForm = new Historial( idDispositivo);
            historialForm.Show();

        }
    }

}

