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
using TP_Final.IO;
using TP_Final.Contract;
using TP_Final.Controller;

namespace TriviaGUI
{
    public partial class Main : Form
    {
        IUserController iUserController;
        ISessionController iSessionController = new SessionController();

        public Main(IUserController pUserController)
        {
            iUserController = pUserController;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewTest testWindow = new NewTest(iUserController.GetAuthenticatedUser());
            testWindow.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UserDTO user = iUserController.GetAuthenticatedUser();
            SessionDTO bestSesssion = iSessionController.GetBestSession(user.Id);

            userData.Text = $"{user.FirstName} {user.LastName}";

            if (bestSesssion != null)
            {
                lBestScore.Text = $"{bestSesssion.Score} puntos";
                lBestTime.Text = $"{bestSesssion.Time.Minutes} minutos, {bestSesssion.Time.Seconds} segundos";
                lBestQuantity.Text = $"{bestSesssion.Quantity} preguntas";
            } else
            {
                lBestScore.Text = $"-";
                lBestTime.Text = $"-";
                lBestQuantity.Text = $"-";
            }

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
            {
                iUserController.LogOutAuthenticatedUser();
                this.Close();
            }
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
            Register register = new Register(iUserController);
            register.ShowDialog();
        }

        private void MUsers_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowDialog();
        }

        private void MOpentDBAdmin_Click(object sender, EventArgs e)
        {
            Questions questions = new Questions();
            questions.ShowDialog();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
