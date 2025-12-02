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
        private Timer fadeTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Define a cor de fundo do formulário
            this.BackColor = Color.FromArgb(255, 255, 255);
            
            // Se você já tiver um PictureBox no designer
            pictureBox1.Image = Image.FromFile(@"C:\Users\a38805\source\repos\PlugNSound\PlugNSound\bin\Debug\logo_plugnsound.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta a imagem proporcionalmente
            
            // Define o Anchor para centralizar como label1 e button1
            pictureBox1.Anchor = AnchorStyles.None;
            
            // Impede redimensionamento manual do formulário
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Desabilita o botão para evitar múltiplos cliques
            button1.Enabled = false;

            // Configura o timer para o fade-out
            fadeTimer = new Timer();
            fadeTimer.Interval = 30; // Intervalo em milissegundos (30ms)
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            // Reduz a opacidade gradualmente
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05; // Diminui a opacidade em 5% a cada tick
            }
            else
            {
                // Para o timer quando a opacidade chega a 0
                fadeTimer.Stop();
                fadeTimer.Dispose();
            }
        }
    }
}