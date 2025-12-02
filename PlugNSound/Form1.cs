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

        private void btnOpenShop_Click(object sender, EventArgs e)
        {
            // Create and show Form2 (the shop)
            Form2 shop = new Form2();
            shop.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create and show Form2
            var shop = new Form2();
            shop.Show();
        }
    }
}
