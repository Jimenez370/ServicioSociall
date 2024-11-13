using System;
using System.Drawing;
using System.Runtime.InteropServices; // Necesario para DllImport
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ServicioSociall
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Form activeForm = null;
        private bool hasClickedServiceOrForm = false;

        public Form1()
        {
            InitializeComponent();
            btnHome.Enabled = false; // Deshabilita el botón Home al inicio
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(IconButton button, Color color)
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
            }

            currentBtn = button;
            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = color;
            currentBtn.IconColor = color;
        }

        private void FormularioRegistroPanel_Click(object sender, EventArgs e)
        {
            ActivateButton((IconButton)sender, Color.FromArgb(172, 126, 241));
            openChildForm(new Form2());
            hasClickedServiceOrForm = true; // Activa la condición
            btnHome.Enabled = true; // Habilita el botón Home
        }

        private void PersonasenServicioPanel_Click(object sender, EventArgs e)
        {
            ActivateButton((IconButton)sender, Color.FromArgb(249, 118, 176));
            openChildForm(new Form3());
            hasClickedServiceOrForm = true; // Activa la condición
            btnHome.Enabled = true; // Habilita el botón Home
        }

        private void ExpediciondeTarjetasPanel_Click(object sender, EventArgs e)
        {
            if (hasClickedServiceOrForm)
            {
                ActivateButton((IconButton)sender, Color.FromArgb(253, 138, 114));
                openChildForm(new Form4());
            }
            else
            {
                MessageBox.Show("Por favor, primero haga clic en 'Personas en Servicio' o 'Formulario Registro'.");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (panelChildForm.Controls.Count > 0)
            {
                panelChildForm.Controls.RemoveAt(0);
            }

            lblTitleChildForm.Text = "Inicio";
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
        }

        // Implementación de los botones de cerrar, maximizar y minimizar
        private void botoncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        private void botonmaximizar_Click(object sender, EventArgs e)
        {
            // Alterna entre maximizar y restaurar la ventana
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void botonminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; // Minimiza la ventana
        }

        // Funcionalidad para arrastrar el formulario desde el panelTitleBar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
