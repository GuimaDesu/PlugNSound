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
        private Form currentChildForm;
        
        public Form2()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            leftBorderBtn.Enabled = false; // Prevent blocking clicks
            PanelMenu.Controls.Add(leftBorderBtn);
            
            // Close application when Form2 is closed
            this.FormClosing += Form2_FormClosing;
            
            // Initialize toggle icon with sun image (light mode)
            UpdateToggleIcon(false);
        }

        private void UpdateToggleIcon(bool showMoon)
        {
            try
            {
                // Use the embedded resource from Properties.Resources
                Bitmap fullImage = Properties.Resources.day_night_icon;
                
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
                if (toggleIcon.Image != null && toggleIcon.Image != Properties.Resources.day_night_icon)
                {
                    toggleIcon.Image.Dispose();
                }
                
                toggleIcon.Image = croppedImage;
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
                // Dark mode - change background colors
                this.BackColor = Color.FromArgb(32, 32, 32);
                panelDesktop.BackColor = Color.FromArgb(32, 32, 32);
            }
            else
            {
                // Light mode - light background
                this.BackColor = Color.White;
                panelDesktop.BackColor = Color.FromArgb(240, 240, 240);
            }
            
            // Apply theme to current child form if exists
            if (currentChildForm != null)
            {
                ApplyThemeToChildForm(currentChildForm);
            }
        }

        private void ApplyThemeToChildForm(Form childForm)
        {
            if (isDarkMode)
            {
                childForm.BackColor = Color.FromArgb(32, 32, 32);
                ApplyThemeToControls(childForm.Controls, true);
            }
            else
            {
                childForm.BackColor = Color.FromArgb(240, 240, 240);
                ApplyThemeToControls(childForm.Controls, false);
            }
        }

        private void ApplyThemeToControls(Control.ControlCollection controls, bool isDark)
        {
            foreach (Control control in controls)
            {
                // Skip ProdutoCard controls - they have their own white background
                if (control is ProdutoCard)
                {
                    continue;
                }
                
                // Apply theme to labels - but skip labels that are white (inside colored panels/cards)
                if (control is Label label)
                {
                    // Don't change white labels (they're on colored backgrounds)
                    if (label.ForeColor != Color.White && 
                        label.ForeColor != Color.FromArgb(255, 255, 255))
                    {
                        // Also skip labels inside panels with gradient backgrounds
                        bool isInColoredPanel = false;
                        if (label.Parent is Panel parentPanel)
                        {
                            // Check if parent panel is a stat card or colored panel
                            if (parentPanel.BackColor == Color.Transparent ||
                                parentPanel.Name.StartsWith("panelCard") ||
                                parentPanel.Name == "panelQuickActions" ||
                                parentPanel.Name == "panelWelcome")
                            {
                                isInColoredPanel = true;
                            }
                        }
                        
                        if (!isInColoredPanel)
                        {
                            label.ForeColor = isDark ? Color.White : Color.Black;
                        }
                    }
                }
                // Apply theme to panels (except special colored panels)
                else if (control is Panel panel && panel.BackColor != Color.Transparent)
                {
                    // Only change panels that have default or light colors
                    if (panel.BackColor == Color.FromArgb(240, 240, 240) || 
                        panel.BackColor == Color.White ||
                        panel.BackColor == Color.FromArgb(32, 32, 32) ||
                        panel.BackColor == Color.FromArgb(245, 245, 250))
                    {
                        panel.BackColor = isDark ? Color.FromArgb(32, 32, 32) : Color.FromArgb(240, 240, 240);
                    }
                }
                // Apply theme to FlowLayoutPanels
                else if (control is FlowLayoutPanel flowPanel)
                {
                    if (flowPanel.BackColor == Color.FromArgb(240, 240, 240) || 
                        flowPanel.BackColor == Color.White ||
                        flowPanel.BackColor == Color.FromArgb(32, 32, 32) ||
                        flowPanel.BackColor == Color.Transparent)
                    {
                        flowPanel.BackColor = isDark ? Color.FromArgb(32, 32, 32) : Color.FromArgb(240, 240, 240);
                    }
                }
                // Apply theme to DataGridViews
                else if (control is DataGridView dgv)
                {
                    if (isDark)
                    {
                        dgv.BackgroundColor = Color.FromArgb(45, 45, 45);
                        dgv.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
                        dgv.DefaultCellStyle.ForeColor = Color.White;
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                        dgv.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgv.GridColor = Color.FromArgb(70, 70, 70);
                    }
                    else
                    {
                        dgv.BackgroundColor = Color.White;
                        dgv.DefaultCellStyle.BackColor = Color.White;
                        dgv.DefaultCellStyle.ForeColor = Color.Black;
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                        dgv.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                        dgv.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
                        dgv.GridColor = SystemColors.ControlDark;
                    }
                }
                
                // Recursively apply to child controls (but not inside ProdutoCard)
                if (control.HasChildren && !(control is ProdutoCard))
                {
                    ApplyThemeToControls(control.Controls, isDark);
                }
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

        private void OpenChildForm(Form childForm)
        {
            // Close previous child form if exists
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
            // Apply current theme to the child form
            ApplyThemeToChildForm(childForm);
            
            // Atualizar contador do carrinho
            AtualizarContadorCarrinho();
        }

        private void AtualizarContadorCarrinho()
        {
            int quantidade = CarrinhoManager.ObterQuantidadeTotal();
            btnCarrinho.Text = $"Carrinho ({quantidade})";
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
            OpenChildForm(new FormDashboard()); // Mostra apenas produtos
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color2);
            OpenChildForm(new FormProdutos());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color3);
            OpenChildForm(new FormCustomers());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color4);
            OpenChildForm(new FormMarketing());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color5);
            OpenChildForm(new FormSettings());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors.color6);
            OpenChildForm(new FormAbout());
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            // Não ativar botão do menu ao abrir carrinho
            disableButton();
            leftBorderBtn.Visible = false;
            OpenChildForm(new FormCarrinho());
            
            // Atualizar título manualmente para o carrinho
            iconPictureBox1.IconChar = IconChar.ShoppingCart;
            iconPictureBox1.IconColor = Color.FromArgb(24, 161, 251);
            lblLittleChildForm.Text = "Carrinho de Compras";
        }

        // Use pictureBox1 as the Home button - abre a dashboard sem produtos
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Desativar botão ativo do menu
            disableButton();
            leftBorderBtn.Visible = false;
            
            // Abrir FormHome (dashboard com estatísticas, sem produtos)
            OpenChildForm(new FormHome());
            
            // Atualizar título para Home
            iconPictureBox1.IconChar = IconChar.House;
            iconPictureBox1.IconColor = Color.FromArgb(90, 24, 154);
            lblLittleChildForm.Text = "Home";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            // Maximize the window
            this.WindowState = FormWindowState.Maximized;
            
            // Apply initial theme (light mode)
            ApplyTheme();
            
            // Abrir Home automaticamente (dashboard com estatísticas)
            pictureBox1_Click(pictureBox1, EventArgs.Empty);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;
            iconPictureBox1.IconChar = IconChar.House;
            iconPictureBox1.IconColor = Color.Gainsboro;
            lblLittleChildForm.Text = "";
            
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }
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