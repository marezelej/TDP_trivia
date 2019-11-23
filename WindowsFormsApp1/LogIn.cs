using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        LoginManager iLogin = new LoginManager();

        public LogIn()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string legajo   = txtFileNumber.Text;
            string password = txtPassword.Text;

            ShowMain();
        }

        private void ShowMain()
        {
            Main mainWindow = new Main();
            mainWindow.FormClosed += MainWindow_FormClosed;
            mainWindow.Show();
            ChangeVisibility();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangeVisibility();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
