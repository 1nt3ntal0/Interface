namespace Interface
{
    partial class Ping
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(537, 30);
            button1.Name = "button1";
            button1.Size = new Size(135, 23);
            button1.TabIndex = 0;
            button1.Text = "Realizar Ping";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(537, 117);
            button2.Name = "button2";
            button2.Size = new Size(135, 23);
            button2.TabIndex = 1;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(51, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(460, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(51, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 269);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(110, 140);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(537, 74);
            button3.Name = "button3";
            button3.Size = new Size(135, 23);
            button3.TabIndex = 10;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Ping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 351);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Ping";
            Text = "Ping";
            Load += Ping_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button button3;
    }
}