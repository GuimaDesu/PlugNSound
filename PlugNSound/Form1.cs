using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlugNSound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Define a cor de fundo do formulário
            this.BackColor = Color.FromArgb(255, 255, 255);
            
            // Se você já tiver um PictureBox no designer
            pictureBox1.Image = Image.FromFile("C:/Users/a25679/source/repos/PlugNSound/PlugNSound/assets/logo_plugnsound.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta a imagem proporcionalmente
            
            // Define o Anchor para centralizar como label1 e button1
            pictureBox1.Anchor = AnchorStyles.None;
            
            // Impede redimensionamento manual do formulário
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            // Maximize the window
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria e exibe Form2
            Form2 form2 = new Form2();
            form2.Show();

            // Fecha Form1
            this.Hide();
        }
    }
}