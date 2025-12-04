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
        private bool isDarkMode = false;
        private Panel togglePanel;
        private Label toggleLabel;
        private PictureBox toggleIcon;
        
        public Form2()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            leftBorderBtn.Enabled = false; // Prevent blocking clicks
            PanelMenu.Controls.Add(leftBorderBtn);
            
            // Close application when Form2 is closed
            this.FormClosing += Form2_FormClosing;
            
            // Create dark mode toggle slider
            CreateDarkModeToggle();
        }

        private void CreateDarkModeToggle()
        {
            // Label
            toggleLabel = new Label();
            toggleLabel.Text = "Dark Mode";
            toggleLabel.ForeColor = Color.White;
            toggleLabel.BackColor = Color.Transparent;
            toggleLabel.Location = new Point(panelTitleBar.Width - 180, 25);
            toggleLabel.AutoSize = true;
            toggleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelTitleBar.Controls.Add(toggleLabel);

            // Toggle background panel (track)
            togglePanel = new Panel();
            togglePanel.Size = new Size(70, 35);
            togglePanel.Location = new Point(panelTitleBar.Width - 100, 18);
            togglePanel.BackColor = Color.FromArgb(200, 200, 200);
            togglePanel.Cursor = Cursors.Hand;
            togglePanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            togglePanel.Click += ToggleSlider_Click;
            panelTitleBar.Controls.Add(togglePanel);

            // Toggle icon - the PictureBox IS the slider now (no background panel)
            // THE IMAGE IS PLACED HERE - this is the sliding element with the sun/moon icon
            toggleIcon = new PictureBox();
            toggleIcon.SizeMode = PictureBoxSizeMode.Zoom;
            toggleIcon.Size = new Size(32, 32);
            toggleIcon.Location = new Point(2, 2);
            toggleIcon.BackColor = Color.Transparent;
            toggleIcon.Cursor = Cursors.Hand;
            toggleIcon.Click += ToggleSlider_Click;
            try
            {
                // Load the combined day/night image and show left half (sun)
                UpdateToggleIcon(false);
            }
            catch
            {
                // Fallback if image not found
                toggleIcon.BackColor = Color.Orange;
            }
            // ADD THE IMAGE TO THE TOGGLE PANEL (the track)
            togglePanel.Controls.Add(toggleIcon);
            toggleIcon.BringToFront();
        }

        private void UpdateToggleIcon(bool showMoon)
        {
            try
            {
                // Use relative path from the application directory
                // This will work on any PC as long as the assets folder is in the project
                string imagePath = System.IO.Path.Combine(Application.StartupPath, @"assets\day-night-icon-sun-orange.JPG");
                
                // Check if file exists
                if (System.IO.File.Exists(imagePath))
                {
                    Bitmap fullImage = new Bitmap(imagePath);
                    
                    // Calculate half width for cropping
                    int halfWidth = fullImage.Width / 2;
                    int sourceX = showMoon ? halfWidth : 0; // Right half for moon, left half for sun
                    
                    // Create a cropped bitmap showing either sun (left) or moon (right)
                    Bitmap croppedImage = new Bitmap(halfWidth, fullImage.Height);
                    using (Graphics g = Graphics.FromImage(croppedImage))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        
                        g.DrawImage(fullImage,
                            new Rectangle(0, 0, halfWidth, fullImage.Height),
                            new Rectangle(sourceX, 0, halfWidth, fullImage.Height),
                            GraphicsUnit.Pixel);
                    }
                    
                    // Dispose old image if exists
                    if (toggleIcon.Image != null)
                    {
                        toggleIcon.Image.Dispose();
                    }
                    
                    toggleIcon.Image = croppedImage;
                    fullImage.Dispose();
                }
                else
                {
                    // File not found - show colored fallback
                    toggleIcon.BackColor = showMoon ? Color.DarkBlue : Color.Orange;
                }
            }
            catch
            {
                toggleIcon.BackColor = showMoon ? Color.DarkBlue : Color.Orange;
            }
        }

        private void ToggleSlider_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            AnimateToggle();
            ApplyTheme();
        }

        private void AnimateToggle()
        {
            Timer animationTimer = new Timer();
            animationTimer.Interval = 10;
            int targetX = isDarkMode ? 36 : 2; // Adjusted for larger slider
            int currentX = toggleIcon.Location.X;
            int step = isDarkMode ? 3 : -3;

            animationTimer.Tick += (s, e) =>
            {
                if ((isDarkMode && currentX >= targetX) || (!isDarkMode && currentX <= targetX))
                {
                    toggleIcon.Location = new Point(targetX, 2);
                    animationTimer.Stop();
                    animationTimer.Dispose();
                }
                else
                {
                    currentX += step;
                    toggleIcon.Location = new Point(currentX, 2);
                }
            };

            // Update toggle panel color and icon
            if (isDarkMode)
            {
                togglePanel.BackColor = Color.FromArgb(95, 77, 221); // Purple when on
                UpdateToggleIcon(true); // Show moon (right half)
            }
            else
            {
                togglePanel.BackColor = Color.FromArgb(200, 200, 200); // Grey when off
                UpdateToggleIcon(false); // Show sun (left half)
            }

            animationTimer.Start();
        }

        private void ApplyTheme()
        {
            if (isDarkMode)
            {
                // Dark mode - only change background
                this.BackColor = Color.FromArgb(32, 32, 32);
            }
            else
            {
                // Light mode - white background
                this.BackColor = Color.White;
            }
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            // Maximize the window
            this.WindowState = FormWindowState.Maximized;
            
            // Apply initial theme (light mode)
            ApplyTheme();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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