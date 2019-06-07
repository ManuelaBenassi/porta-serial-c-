namespace ap19184
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbxPortas = new System.Windows.Forms.ComboBox();
            this.spSerial = new System.IO.Ports.SerialPort(this.components);
            this.btnConectar = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxPortas
            // 
            this.cbxPortas.FormattingEnabled = true;
            this.cbxPortas.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13"});
            this.cbxPortas.Location = new System.Drawing.Point(246, 125);
            this.cbxPortas.Name = "cbxPortas";
            this.cbxPortas.Size = new System.Drawing.Size(164, 21);
            this.cbxPortas.TabIndex = 6;
            // 
            // spSerial
            // 
            this.spSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(246, 178);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(164, 45);
            this.btnConectar.TabIndex = 7;
            this.btnConectar.Text = " Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btn5
            // 
            this.btn5.Image = global::ap19184.Properties.Resources.LED3ON;
            this.btn5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn5.Location = new System.Drawing.Point(25, 231);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(165, 47);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "Piscar de fora pra dentro";
            this.btn5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Image = global::ap19184.Properties.Resources.LED3OFF;
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4.Location = new System.Drawing.Point(25, 125);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(165, 47);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Piscar de dentro pra fora";
            this.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Image = global::ap19184.Properties.Resources.LED2OFF;
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.Location = new System.Drawing.Point(25, 72);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(165, 47);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Piscar os verdes";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Image = global::ap19184.Properties.Resources.LED1OFF;
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.Location = new System.Drawing.Point(25, 178);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(165, 47);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Piscar os intercalados";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Image = global::ap19184.Properties.Resources.LED1ON;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.Location = new System.Drawing.Point(25, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(165, 47);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Piscar os vermelhos";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(441, 322);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cbxPortas);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Porta Serial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.ComboBox cbxPortas;
        private System.IO.Ports.SerialPort spSerial;
        private System.Windows.Forms.Button btnConectar;
    }
}

