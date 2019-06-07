using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ap19184
{
    
    public partial class Form1 : Form
    {
        string RxString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            spSerial.Write("1");//mandar o numero pro arduino
            btn1.Image = Properties.Resources.aceso;//mudar a imagem durante 
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = spSerial.ReadExisting();
            Invoke(new EventHandler(trataDadoRecebido));
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!spSerial.IsOpen)
            {
                try
                {
                    spSerial.PortName = cbxPortas.Items[cbxPortas.SelectedIndex].ToString(); // usar a porta selecionada
                    spSerial.Open(); //abrir a porta
                }
                catch
                {
                    return;
                }
                if (spSerial.IsOpen) //se abriu
                {
                    btnConectar.Text = "Desconectar"; // mudar o texto do botão
                    cbxPortas.Enabled = false; // desabilitar a combobox
                }
            }
            else //fechar a porta se tiver aberta
            {
                try
                {
                    spSerial.Close(); 
                    cbxPortas.Enabled = true; 
                    btnConectar.Text = "Conectar"; 
                    HabilitarBotoes();
                    VoltarImagens();
                }
                catch
                {
                    return;
                }
            }
        }
        private void trataDadoRecebido(object sender, EventArgs e)//quando acabar, volta os botões
        {
            if (RxString == "0") 
            {
                HabilitarBotoes();
                VoltarImagens();
            }
        }
        void HabilitarBotoes() 
        {
            btnConectar.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
        }
        void VoltarImagens() // volta as imagens iniciais

        {
            btn1.Image = Properties.Resources.LED1ON;
            btn2.Image = Properties.Resources.LED2OFF;
            btn3.Image = Properties.Resources.LED3OFF;
            btn4.Image = Properties.Resources.LED1OFF;
            btn5.Image = Properties.Resources.LED3ON;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            spSerial.Write("2");
            btn3.Image = Properties.Resources.aceso;
            


        }

        private void btn4_Click(object sender, EventArgs e)
        {
            spSerial.Write("3");
            btn4.Image = Properties.Resources.aceso;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            spSerial.Write("4");
            btn2.Image = Properties.Resources.aceso;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            spSerial.Write("5");
            btn5.Image = Properties.Resources.aceso;
        }
    }
   
}
