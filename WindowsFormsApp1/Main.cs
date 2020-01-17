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

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewTest testWindow = new NewTest();
            testWindow.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            string messageBoxText = "¿Desea cerrar la sesión?";
            string caption = "Cerrar Sesión";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Question;

            MessageBoxResult result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void UserData_Enter(object sender, EventArgs e)
        {

        }

        private void MChangePassword_Click(object sender, EventArgs e)
        {
            NewPassword NewPW = new NewPassword();
            NewPW.ShowDialog();
        }

        private void MSessionRanking_Click(object sender, EventArgs e)
        {
            Ranking ranking = new Ranking();
            ranking.ShowDialog();
        }

        private void MMySessions_Click(object sender, EventArgs e)
        {
            MyRank myrank = new MyRank();
            myrank.ShowDialog();
        }

        private void MCreateUser_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void MUsers_Click(object sender, EventArgs e)
        {
            UserManager usermanager = new UserManager();
            usermanager.ShowDialog();
        }
    }
}
