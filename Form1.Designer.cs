namespace Interface
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bindingSource1 = new BindingSource(components);
            onOff1 = new controles.OnOff();
            panel3 = new Panel();
            menuStrip1 = new MenuStrip();
            salaToolStripMenuItem = new ToolStripMenuItem();
            verDetallesToolStripMenuItem = new ToolStripMenuItem();
            verHistorialToolStripMenuItem = new ToolStripMenuItem();
            panel4 = new Panel();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            panel5 = new Panel();
            menuStrip3 = new MenuStrip();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            panel6 = new Panel();
            menuStrip4 = new MenuStrip();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            panel7 = new Panel();
            menuStrip5 = new MenuStrip();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            toolStripMenuItem12 = new ToolStripMenuItem();
            panel8 = new Panel();
            menuStrip6 = new MenuStrip();
            toolStripMenuItem13 = new ToolStripMenuItem();
            toolStripMenuItem14 = new ToolStripMenuItem();
            toolStripMenuItem15 = new ToolStripMenuItem();
            panel9 = new Panel();
            menuStrip7 = new MenuStrip();
            toolStripMenuItem16 = new ToolStripMenuItem();
            toolStripMenuItem17 = new ToolStripMenuItem();
            toolStripMenuItem18 = new ToolStripMenuItem();
            cambiarIdiomaToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            panel1 = new Panel();
            menuStrip8 = new MenuStrip();
            toolStripMenuItem19 = new ToolStripMenuItem();
            toolStripMenuItem20 = new ToolStripMenuItem();
            toolStripMenuItem21 = new ToolStripMenuItem();
            panel10 = new Panel();
            menuStrip9 = new MenuStrip();
            toolStripMenuItem22 = new ToolStripMenuItem();
            toolStripMenuItem23 = new ToolStripMenuItem();
            toolStripMenuItem24 = new ToolStripMenuItem();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            pictureBox3 = new PictureBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            textBox22 = new TextBox();
            textBox12 = new TextBox();
            panel2 = new Panel();
            menuStrip10 = new MenuStrip();
            toolStripMenuItem25 = new ToolStripMenuItem();
            toolStripMenuItem26 = new ToolStripMenuItem();
            toolStripMenuItem27 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            menuStrip2.SuspendLayout();
            panel5.SuspendLayout();
            menuStrip3.SuspendLayout();
            panel6.SuspendLayout();
            menuStrip4.SuspendLayout();
            panel7.SuspendLayout();
            menuStrip5.SuspendLayout();
            panel8.SuspendLayout();
            menuStrip6.SuspendLayout();
            panel9.SuspendLayout();
            menuStrip7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            menuStrip8.SuspendLayout();
            panel10.SuspendLayout();
            menuStrip9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            menuStrip10.SuspendLayout();
            SuspendLayout();
            // 
            // onOff1
            // 
            onOff1.AutoSize = true;
            onOff1.Location = new Point(1001, 40);
            onOff1.MinimumSize = new Size(45, 20);
            onOff1.Name = "onOff1";
            onOff1.Size = new Size(63, 20);
            onOff1.TabIndex = 1;
            onOff1.Text = "onOff1";
            onOff1.UseVisualStyleBackColor = true;
            onOff1.CheckedChanged += onOff1_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(menuStrip1);
            panel3.ForeColor = SystemColors.AppWorkspace;
            panel3.Location = new Point(962, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(161, 45);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { salaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(161, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // salaToolStripMenuItem
            // 
            salaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verDetallesToolStripMenuItem, verHistorialToolStripMenuItem });
            salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            salaToolStripMenuItem.Size = new Size(86, 20);
            salaToolStripMenuItem.Text = "Habitacion 1";
            salaToolStripMenuItem.Click += salaToolStripMenuItem_Click_1;
            // 
            // verDetallesToolStripMenuItem
            // 
            verDetallesToolStripMenuItem.Name = "verDetallesToolStripMenuItem";
            verDetallesToolStripMenuItem.Size = new Size(180, 22);
            verDetallesToolStripMenuItem.Text = "Ver Detalles";
            verDetallesToolStripMenuItem.Click += verDetallesToolStripMenuItem_Click;
            // 
            // verHistorialToolStripMenuItem
            // 
            verHistorialToolStripMenuItem.Name = "verHistorialToolStripMenuItem";
            verHistorialToolStripMenuItem.Size = new Size(180, 22);
            verHistorialToolStripMenuItem.Text = "Ver Historial";
            verHistorialToolStripMenuItem.Click += verHistorialToolStripMenuItem_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(menuStrip2);
            panel4.Location = new Point(962, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(161, 45);
            panel4.TabIndex = 7;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(161, 24);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(86, 20);
            toolStripMenuItem1.Text = "Habitacion 2";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(137, 22);
            toolStripMenuItem2.Text = "Ver Detalles";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Ver Historial";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(menuStrip3);
            panel5.Location = new Point(962, 283);
            panel5.Name = "panel5";
            panel5.Size = new Size(161, 45);
            panel5.TabIndex = 8;
            // 
            // menuStrip3
            // 
            menuStrip3.Items.AddRange(new ToolStripItem[] { toolStripMenuItem4 });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(161, 24);
            menuStrip3.TabIndex = 0;
            menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem6 });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(89, 20);
            toolStripMenuItem4.Text = "Habitacion 1 ";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(137, 22);
            toolStripMenuItem5.Text = "Ver Detalles";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(180, 22);
            toolStripMenuItem6.Text = "Ver Historial";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(menuStrip4);
            panel6.Location = new Point(962, 232);
            panel6.Name = "panel6";
            panel6.Size = new Size(161, 45);
            panel6.TabIndex = 8;
            // 
            // menuStrip4
            // 
            menuStrip4.Items.AddRange(new ToolStripItem[] { toolStripMenuItem7 });
            menuStrip4.Location = new Point(0, 0);
            menuStrip4.Name = "menuStrip4";
            menuStrip4.Size = new Size(161, 24);
            menuStrip4.TabIndex = 0;
            menuStrip4.Text = "menuStrip4";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem8, toolStripMenuItem9 });
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(86, 20);
            toolStripMenuItem7.Text = "Habitacion 4";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(137, 22);
            toolStripMenuItem8.Text = "Ver Detalles";
            toolStripMenuItem8.Click += toolStripMenuItem8_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(180, 22);
            toolStripMenuItem9.Text = "Ver Historial";
            toolStripMenuItem9.Click += toolStripMenuItem9_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(menuStrip5);
            panel7.Location = new Point(962, 181);
            panel7.Name = "panel7";
            panel7.Size = new Size(161, 45);
            panel7.TabIndex = 8;
            // 
            // menuStrip5
            // 
            menuStrip5.Items.AddRange(new ToolStripItem[] { toolStripMenuItem10 });
            menuStrip5.Location = new Point(0, 0);
            menuStrip5.Name = "menuStrip5";
            menuStrip5.Size = new Size(161, 24);
            menuStrip5.TabIndex = 0;
            menuStrip5.Text = "menuStrip5";
            menuStrip5.ItemClicked += menuStrip5_ItemClicked;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem11, toolStripMenuItem12 });
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(86, 20);
            toolStripMenuItem10.Text = "Habitacion 3";
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(137, 22);
            toolStripMenuItem11.Text = "Ver Detalles";
            toolStripMenuItem11.Click += toolStripMenuItem11_Click;
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.Size = new Size(180, 22);
            toolStripMenuItem12.Text = "Ver Historial";
            toolStripMenuItem12.Click += toolStripMenuItem12_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(menuStrip6);
            panel8.Location = new Point(962, 334);
            panel8.Name = "panel8";
            panel8.Size = new Size(161, 45);
            panel8.TabIndex = 8;
            panel8.Paint += panel8_Paint;
            // 
            // menuStrip6
            // 
            menuStrip6.Items.AddRange(new ToolStripItem[] { toolStripMenuItem13 });
            menuStrip6.Location = new Point(0, 0);
            menuStrip6.Name = "menuStrip6";
            menuStrip6.Size = new Size(161, 24);
            menuStrip6.TabIndex = 0;
            menuStrip6.Text = "menuStrip6";
            menuStrip6.ItemClicked += menuStrip6_ItemClicked;
            // 
            // toolStripMenuItem13
            // 
            toolStripMenuItem13.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem14, toolStripMenuItem15 });
            toolStripMenuItem13.Name = "toolStripMenuItem13";
            toolStripMenuItem13.Size = new Size(86, 20);
            toolStripMenuItem13.Text = "Habitacion 2";
            // 
            // toolStripMenuItem14
            // 
            toolStripMenuItem14.Name = "toolStripMenuItem14";
            toolStripMenuItem14.Size = new Size(137, 22);
            toolStripMenuItem14.Text = "Ver Detalles";
            toolStripMenuItem14.Click += toolStripMenuItem14_Click;
            // 
            // toolStripMenuItem15
            // 
            toolStripMenuItem15.Name = "toolStripMenuItem15";
            toolStripMenuItem15.Size = new Size(180, 22);
            toolStripMenuItem15.Text = "Ver Historial";
            toolStripMenuItem15.Click += toolStripMenuItem15_Click;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonFace;
            panel9.Controls.Add(menuStrip7);
            panel9.Location = new Point(939, 557);
            panel9.Name = "panel9";
            panel9.Size = new Size(184, 131);
            panel9.TabIndex = 9;
            // 
            // menuStrip7
            // 
            menuStrip7.Items.AddRange(new ToolStripItem[] { toolStripMenuItem16 });
            menuStrip7.Location = new Point(0, 0);
            menuStrip7.Name = "menuStrip7";
            menuStrip7.Size = new Size(184, 24);
            menuStrip7.TabIndex = 0;
            menuStrip7.Text = "menuStrip7";
            // 
            // toolStripMenuItem16
            // 
            toolStripMenuItem16.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem17, toolStripMenuItem18, cambiarIdiomaToolStripMenuItem });
            toolStripMenuItem16.Name = "toolStripMenuItem16";
            toolStripMenuItem16.Size = new Size(71, 20);
            toolStripMenuItem16.Text = "Utilidades";
            // 
            // toolStripMenuItem17
            // 
            toolStripMenuItem17.Name = "toolStripMenuItem17";
            toolStripMenuItem17.Size = new Size(180, 22);
            toolStripMenuItem17.Text = "Grafica";
            // 
            // toolStripMenuItem18
            // 
            toolStripMenuItem18.Name = "toolStripMenuItem18";
            toolStripMenuItem18.Size = new Size(180, 22);
            toolStripMenuItem18.Text = "Ping";
            toolStripMenuItem18.Click += toolStripMenuItem18_Click;
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            cambiarIdiomaToolStripMenuItem.Size = new Size(180, 22);
            cambiarIdiomaToolStripMenuItem.Text = "Cambiar Idioma";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 511);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(515, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(407, 511);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.WaitOnLoad = true;
            // 
            // button1
            // 
            button1.CausesValidation = false;
            button1.Enabled = false;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(975, 12);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 12;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(128, 255, 255);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(130, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(78, 23);
            textBox1.TabIndex = 13;
            textBox1.Text = "Habitacion 1";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(372, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 23);
            textBox2.TabIndex = 14;
            textBox2.Text = "Habitacion 2";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(372, 367);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(78, 23);
            textBox3.TabIndex = 15;
            textBox3.Text = "Habitacion 3";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(130, 335);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(78, 23);
            textBox4.TabIndex = 16;
            textBox4.Text = "Habitacion 4";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(547, 101);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(78, 23);
            textBox5.TabIndex = 17;
            textBox5.Text = "Habitacion 1";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(547, 335);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(78, 23);
            textBox6.TabIndex = 18;
            textBox6.Text = "Habitacion 5";
            textBox6.TextChanged += TextBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(547, 482);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(78, 23);
            textBox7.TabIndex = 19;
            textBox7.Text = "Habitacion 4";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(785, 232);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(78, 23);
            textBox8.TabIndex = 20;
            textBox8.Text = "Habitacion 2";
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(785, 436);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(78, 23);
            textBox9.TabIndex = 21;
            textBox9.Text = "Habitacion 3";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip8);
            panel1.Location = new Point(962, 385);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 45);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint_2;
            // 
            // menuStrip8
            // 
            menuStrip8.Items.AddRange(new ToolStripItem[] { toolStripMenuItem19 });
            menuStrip8.Location = new Point(0, 0);
            menuStrip8.Name = "menuStrip8";
            menuStrip8.Size = new Size(161, 24);
            menuStrip8.TabIndex = 0;
            menuStrip8.Text = "menuStrip8";
            menuStrip8.ItemClicked += menuStrip8_ItemClicked;
            // 
            // toolStripMenuItem19
            // 
            toolStripMenuItem19.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem20, toolStripMenuItem21 });
            toolStripMenuItem19.Name = "toolStripMenuItem19";
            toolStripMenuItem19.Size = new Size(86, 20);
            toolStripMenuItem19.Text = "Habitacion 3";
            toolStripMenuItem19.Click += toolStripMenuItem19_Click;
            // 
            // toolStripMenuItem20
            // 
            toolStripMenuItem20.Name = "toolStripMenuItem20";
            toolStripMenuItem20.Size = new Size(137, 22);
            toolStripMenuItem20.Text = "Ver Detalles";
            toolStripMenuItem20.Click += toolStripMenuItem20_Click;
            // 
            // toolStripMenuItem21
            // 
            toolStripMenuItem21.Name = "toolStripMenuItem21";
            toolStripMenuItem21.Size = new Size(180, 22);
            toolStripMenuItem21.Text = "Ver Historial";
            toolStripMenuItem21.Click += toolStripMenuItem21_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(menuStrip9);
            panel10.Location = new Point(962, 436);
            panel10.Name = "panel10";
            panel10.Size = new Size(161, 45);
            panel10.TabIndex = 9;
            panel10.Paint += panel10_Paint;
            // 
            // menuStrip9
            // 
            menuStrip9.Items.AddRange(new ToolStripItem[] { toolStripMenuItem22 });
            menuStrip9.Location = new Point(0, 0);
            menuStrip9.Name = "menuStrip9";
            menuStrip9.Size = new Size(161, 24);
            menuStrip9.TabIndex = 0;
            menuStrip9.Text = "menuStrip9";
            menuStrip9.ItemClicked += menuStrip9_ItemClicked;
            // 
            // toolStripMenuItem22
            // 
            toolStripMenuItem22.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem23, toolStripMenuItem24 });
            toolStripMenuItem22.Name = "toolStripMenuItem22";
            toolStripMenuItem22.Size = new Size(86, 20);
            toolStripMenuItem22.Text = "Habitacion 4";
            // 
            // toolStripMenuItem23
            // 
            toolStripMenuItem23.Name = "toolStripMenuItem23";
            toolStripMenuItem23.Size = new Size(137, 22);
            toolStripMenuItem23.Text = "Ver Detalles";
            toolStripMenuItem23.Click += toolStripMenuItem23_Click;
            // 
            // toolStripMenuItem24
            // 
            toolStripMenuItem24.Name = "toolStripMenuItem24";
            toolStripMenuItem24.Size = new Size(180, 22);
            toolStripMenuItem24.Text = "Ver Historial";
            toolStripMenuItem24.Click += toolStripMenuItem24_Click;
            // 
            // textBox10
            // 
            textBox10.Enabled = false;
            textBox10.Location = new Point(233, 12);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(78, 23);
            textBox10.TabIndex = 22;
            textBox10.Text = "Planta 1";
            textBox10.TextAlign = HorizontalAlignment.Center;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Enabled = false;
            textBox11.Location = new Point(680, 12);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(78, 23);
            textBox11.TabIndex = 23;
            textBox11.Text = "Planta 2";
            textBox11.TextAlign = HorizontalAlignment.Center;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources_es.NotificacionVisual2;
            pictureBox3.Location = new Point(82, 557);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 131);
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // textBox14
            // 
            textBox14.Enabled = false;
            textBox14.HideSelection = false;
            textBox14.Location = new Point(214, 648);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.ScrollBars = ScrollBars.Vertical;
            textBox14.Size = new Size(699, 40);
            textBox14.TabIndex = 27;
            textBox14.Visible = false;
            textBox14.TextChanged += textBox14_TextChanged_1;
            // 
            // textBox13
            // 
            textBox13.Enabled = false;
            textBox13.Location = new Point(130, 109);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(78, 23);
            textBox13.TabIndex = 28;
            textBox13.Text = "Valor hab 1";
            textBox13.TextAlign = HorizontalAlignment.Center;
            textBox13.Visible = false;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // textBox15
            // 
            textBox15.Enabled = false;
            textBox15.Location = new Point(372, 210);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new Size(78, 23);
            textBox15.TabIndex = 29;
            textBox15.Text = "Valor hab 2";
            textBox15.TextAlign = HorizontalAlignment.Center;
            textBox15.Visible = false;
            textBox15.TextChanged += textBox15_TextChanged;
            // 
            // textBox16
            // 
            textBox16.Enabled = false;
            textBox16.Location = new Point(372, 396);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            textBox16.Size = new Size(78, 23);
            textBox16.TabIndex = 30;
            textBox16.Text = "Valor hab 3";
            textBox16.TextAlign = HorizontalAlignment.Center;
            textBox16.Visible = false;
            textBox16.TextChanged += textBox16_TextChanged;
            // 
            // textBox17
            // 
            textBox17.Enabled = false;
            textBox17.Location = new Point(547, 130);
            textBox17.Multiline = true;
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            textBox17.Size = new Size(78, 23);
            textBox17.TabIndex = 31;
            textBox17.Text = "Valor hab 1";
            textBox17.TextAlign = HorizontalAlignment.Center;
            textBox17.Visible = false;
            textBox17.TextChanged += textBox17_TextChanged;
            // 
            // textBox18
            // 
            textBox18.Enabled = false;
            textBox18.Location = new Point(130, 364);
            textBox18.Multiline = true;
            textBox18.Name = "textBox18";
            textBox18.ReadOnly = true;
            textBox18.Size = new Size(78, 23);
            textBox18.TabIndex = 32;
            textBox18.Text = "Valor hab 4";
            textBox18.TextAlign = HorizontalAlignment.Center;
            textBox18.Visible = false;
            textBox18.TextChanged += textBox18_TextChanged;
            // 
            // textBox19
            // 
            textBox19.Enabled = false;
            textBox19.Location = new Point(547, 511);
            textBox19.Multiline = true;
            textBox19.Name = "textBox19";
            textBox19.ReadOnly = true;
            textBox19.Size = new Size(78, 23);
            textBox19.TabIndex = 33;
            textBox19.Text = "Valor hab 4";
            textBox19.TextAlign = HorizontalAlignment.Center;
            textBox19.Visible = false;
            textBox19.TextChanged += textBox19_TextChanged;
            // 
            // textBox20
            // 
            textBox20.Enabled = false;
            textBox20.Location = new Point(547, 364);
            textBox20.Multiline = true;
            textBox20.Name = "textBox20";
            textBox20.ReadOnly = true;
            textBox20.Size = new Size(78, 23);
            textBox20.TabIndex = 34;
            textBox20.Text = "Valor hab 5";
            textBox20.TextAlign = HorizontalAlignment.Center;
            textBox20.Visible = false;
            textBox20.TextChanged += textBox20_TextChanged;
            // 
            // textBox21
            // 
            textBox21.Enabled = false;
            textBox21.Location = new Point(785, 465);
            textBox21.Multiline = true;
            textBox21.Name = "textBox21";
            textBox21.ReadOnly = true;
            textBox21.Size = new Size(78, 23);
            textBox21.TabIndex = 35;
            textBox21.Text = "Valor Hab 3";
            textBox21.TextAlign = HorizontalAlignment.Center;
            textBox21.Visible = false;
            textBox21.TextChanged += textBox21_TextChanged;
            // 
            // textBox22
            // 
            textBox22.Enabled = false;
            textBox22.Location = new Point(785, 261);
            textBox22.Multiline = true;
            textBox22.Name = "textBox22";
            textBox22.ReadOnly = true;
            textBox22.Size = new Size(78, 23);
            textBox22.TabIndex = 36;
            textBox22.Text = "Valor Hab 2";
            textBox22.TextAlign = HorizontalAlignment.Center;
            textBox22.Visible = false;
            textBox22.TextChanged += textBox22_TextChanged;
            // 
            // textBox12
            // 
            textBox12.Enabled = false;
            textBox12.HideSelection = false;
            textBox12.Location = new Point(214, 557);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.ScrollBars = ScrollBars.Vertical;
            textBox12.Size = new Size(699, 85);
            textBox12.TabIndex = 37;
            textBox12.Visible = false;
            textBox12.TextChanged += textBox12_TextChanged_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip10);
            panel2.Location = new Point(962, 482);
            panel2.Name = "panel2";
            panel2.Size = new Size(161, 45);
            panel2.TabIndex = 10;
            // 
            // menuStrip10
            // 
            menuStrip10.Items.AddRange(new ToolStripItem[] { toolStripMenuItem25 });
            menuStrip10.Location = new Point(0, 0);
            menuStrip10.Name = "menuStrip10";
            menuStrip10.Size = new Size(161, 24);
            menuStrip10.TabIndex = 0;
            menuStrip10.Text = "menuStrip10";
            // 
            // toolStripMenuItem25
            // 
            toolStripMenuItem25.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem26, toolStripMenuItem27 });
            toolStripMenuItem25.Name = "toolStripMenuItem25";
            toolStripMenuItem25.Size = new Size(86, 20);
            toolStripMenuItem25.Text = "Habitacion 5";
            // 
            // toolStripMenuItem26
            // 
            toolStripMenuItem26.Name = "toolStripMenuItem26";
            toolStripMenuItem26.Size = new Size(137, 22);
            toolStripMenuItem26.Text = "Ver Detalles";
            toolStripMenuItem26.Click += toolStripMenuItem26_Click;
            // 
            // toolStripMenuItem27
            // 
            toolStripMenuItem27.Name = "toolStripMenuItem27";
            toolStripMenuItem27.Size = new Size(180, 22);
            toolStripMenuItem27.Text = "Ver Historial";
            toolStripMenuItem27.Click += toolStripMenuItem27_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1135, 690);
            Controls.Add(panel2);
            Controls.Add(textBox12);
            Controls.Add(textBox22);
            Controls.Add(textBox21);
            Controls.Add(textBox20);
            Controls.Add(textBox19);
            Controls.Add(textBox18);
            Controls.Add(textBox17);
            Controls.Add(textBox16);
            Controls.Add(textBox15);
            Controls.Add(textBox13);
            Controls.Add(textBox14);
            Controls.Add(pictureBox3);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(onOff1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            menuStrip4.ResumeLayout(false);
            menuStrip4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            menuStrip5.ResumeLayout(false);
            menuStrip5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            menuStrip6.ResumeLayout(false);
            menuStrip6.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            menuStrip7.ResumeLayout(false);
            menuStrip7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip8.ResumeLayout(false);
            menuStrip8.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            menuStrip9.ResumeLayout(false);
            menuStrip9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip10.ResumeLayout(false);
            menuStrip10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private BindingSource bindingSource1;
        private controles.OnOff onOff1;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salaToolStripMenuItem;
        private ToolStripMenuItem verDetallesToolStripMenuItem;
        private ToolStripMenuItem verHistorialToolStripMenuItem;
        private Panel panel4;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Panel panel5;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private Panel panel6;
        private MenuStrip menuStrip4;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private Panel panel7;
        private MenuStrip menuStrip5;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private Panel panel8;
        private MenuStrip menuStrip6;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private Panel panel9;
        private MenuStrip menuStrip7;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem18;
        private ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Panel panel1;
        private MenuStrip menuStrip8;
        private ToolStripMenuItem toolStripMenuItem19;
        private ToolStripMenuItem toolStripMenuItem20;
        private ToolStripMenuItem toolStripMenuItem21;
        private Panel panel10;
        private MenuStrip menuStrip9;
        private ToolStripMenuItem toolStripMenuItem22;
        private ToolStripMenuItem toolStripMenuItem23;
        private ToolStripMenuItem toolStripMenuItem24;
        private TextBox textBox10;
        private TextBox textBox11;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox3;
        private TextBox textBox14;
        private TextBox textBox22;
        private TextBox textBox21;
        private TextBox textBox20;
        private TextBox textBox19;
        private TextBox textBox18;
        private TextBox textBox17;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox13;
        private TextBox textBox12;
        private Panel panel2;
        private MenuStrip menuStrip10;
        private ToolStripMenuItem toolStripMenuItem25;
        private ToolStripMenuItem toolStripMenuItem26;
        private ToolStripMenuItem toolStripMenuItem27;
    }
}