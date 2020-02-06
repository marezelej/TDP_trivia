using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TP_Final;

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        UsersFacade iUsersFacade = new UsersFacade();

        public LogIn()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fileNumber   = txtFileNumber.Text;
            string password     = txtPassword.Text;

            if(!iUsersFacade.Authenticate(fileNumber, password))
            {
                System.Windows.MessageBox.Show(
                    "Las credenciales son incorrectas. Por favor, reintentar...",
                    "Error de autenticación",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                return;
            }

            ShowMain();
        }

        private void ShowMain()
        {
            Main mainWindow = new Main(iUsersFacade);
            mainWindow.FormClosed += MainWindow_FormClosed;
            mainWindow.Show();
            ChangeVisibility();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangeVisibility();
        }

        private void txtFileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerWindow = new Register();
            registerWindow.ShowDialog();
        }

        private void ChangeVisibility()
        {
            Visible = !Visible;
            txtFileNumber.Text = "";
            txtPassword.Text = "";
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
