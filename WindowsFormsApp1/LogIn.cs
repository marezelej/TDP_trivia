using System;
using System.Windows;
using System.Windows.Forms;
using TP_Final.Contract;
using TP_Final.Controller;
using TP_Final.Error.Authentication;

namespace TriviaGUI
{
    public partial class LogIn : Form
    {
        IUserController iUsersFacade = new UserController();

        public LogIn()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs eventArgs)
        {
            string fileNumber   = txtFileNumber.Text;
            string password     = txtPassword.Text;

            try
            {
                iUsersFacade.Authenticate(fileNumber, password);
            } catch (WrongFileNameException)
            {
                System.Windows.MessageBox.Show(
                    "El número de legajo no se encuentra en el sistema. Por favor, reintentar...",
                    "Error de autenticación",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                return;
            }
            catch (WrongPasswordException)
            {
                System.Windows.MessageBox.Show(
                    "La contraseña es incorrecta. Por favor, reintentar...",
                    "Error de autenticación",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                return;
            } catch (Exception e)
            {
                System.Console.WriteLine(e);
                System.Windows.MessageBox.Show(
                    "Ocurrió un error inesperado. Por favor, reintentar...",
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
            Register registerWindow = new Register(iUsersFacade);
            registerWindow.ShowDialog();
        }

        private void ChangeVisibility()
        {
            Visible             = !Visible;
            txtFileNumber.Text  = "";
            txtPassword.Text    = "";
        }
    }
}
