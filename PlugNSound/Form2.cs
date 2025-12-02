using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PlugNSound
{
    public partial class Form2 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public Form2()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            leftBorderBtn.Enabled = false; // Prevent blocking clicks
            PanelMenu.Controls.Add(leftBorderBtn);
        }

        private struct rgbColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            // Reset previous button appearance
            disableButton();

            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                // Use a darker version of the accent color for background
                currentBtn.BackColor = Color.FromArgb(
                    Math.Max(color.R - 100, 30),
                    Math.Max(color.G - 100, 30),
                    Math.Max(color.B - 100, 68)
                );
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Use designer iconPictureBox1 for the title icon
                iconPictureBox1.IconChar = currentBtn.IconChar;
                iconPictureBox1.IconColor = color;

                // Update title text for the selected tab
                lblLittleChildForm.Text = currentBtn.Text;
            }
        }

        private void disableButton()
        {
            if (currentBtn != null)
            {
                // Reset to the panel's background color
                currentBtn.BackColor = PanelMenu.BackColor;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color1);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color2);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color4);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color5);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color6);
        }

        // Use pictureBox1 as the Home button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;
            iconPictureBox1.IconChar = IconChar.House; // Use designer icon
            iconPictureBox1.IconColor = Color.Gainsboro;
            // Set small label and little title appropriately for Home
            lblLittleChildForm.Text = ""; // Clear little title label
        }

        // Drag Form2 by the title bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}