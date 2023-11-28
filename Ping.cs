using System.Diagnostics;

namespace Interface
{
    public partial class Ping : Form
    {
        private string pingpong;

        public Ping()
        {
            InitializeComponent();
        }

        private string RemoveFirstAndLastLines(string input)
        {
            string[] lines = input.Split('\n');

            if (lines.Length < 8)
            {
                return input;
            }

            string[] trimmedLines = lines.Skip(6).Take(lines.Length - 7).ToArray();

            return string.Join("\n", trimmedLines);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pingpong))
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        RedirectStandardInput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    };

                    Process process = new Process { StartInfo = psi };
                    process.Start();

                    process.StandardInput.WriteLine($"ping {pingpong}");
                    process.StandardInput.Flush();
                    process.StandardInput.Close();

                    string result = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    result = RemoveFirstAndLastLines(result);
                    label1.ForeColor = System.Drawing.Color.Green;
                    label1.Text = "Resultado del ping:\n" + result;
                    label1.Visible = true;
                    pictureBox1.Visible = true;
                    textBox1.Text = "";
                }
                catch (Exception ex)
                {
                    label1.Text = $"Error al ejecutar el ping: {ex.Message}";
                }
            }
            else
            {
                label1.Text = "Por favor, ingrese una dirección válida en el campo de texto.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pingpong = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            this.Close();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void Ping_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox1.Visible = false;

        }
    }
}
