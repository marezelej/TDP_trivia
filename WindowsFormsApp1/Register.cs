using Catel.Services;
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

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        private UsersFacade iUsersFacade = new UsersFacade();

        public Register()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string messageBoxText       = "¿Desea cancelar el registro?";
            string caption              = "Cancelar Registro";
            MessageBoxButton button     = MessageBoxButton.YesNo;
            MessageBoxImage icon        = MessageBoxImage.Warning;
            

            MessageBoxResult result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);

            if(result == MessageBoxResult.Yes)
                this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(!InformationIsValid())
                return;

            if(!UserAcceptsRegistration())
                return;

            if (!ResgisterUser())
                return;

            ShowSuccessNotification();

            Close();
        }

        private void ShowSuccessNotification()
        {
            string messageBoxText       = "El nuevo usuario fué registrado correctamente"; 
            string caption              = "Registro correcto";
            MessageBoxButton button     = MessageBoxButton.OK;
            MessageBoxImage icon        = MessageBoxImage.Information;

            System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);
        }

        private bool ResgisterUser()
        {
            UserDTO user = new UserDTO()
            {
                FirstName        = txtFirstName.Text,
                LastName    = txtLastName.Text,
                FileNumber  = txtFileNumber.Text,
                Password    = txtPassword.Text
            };

            try
            {
                iUsersFacade.CreateUser(user);
            }
            catch(Exception)
            {
                System.Windows.MessageBox.Show(
                    "Ocurrió un error inesperado al guardar el usuario. Por favor, reintentar...",
                    "Error inesperado",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
                return false;
            }

            return true;
        }

        private bool InformationIsValid()
        {
            if (txtFirstName.Text.Length == 0)
            {
                System.Windows.MessageBox.Show(
                    "Debe ingresar su nombre",
                    "Error de validación",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                return false;
            }

            if (txtFileNumber.Text.Length < 8)
            {
                System.Windows.MessageBox.Show(
                    "El número de legajo debe poseer al menos 8 caractéres",
                    "Error de validación",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                return false;
            }

            if (!txtPassword.Text.Equals(txtRepeatPassword.Text))
            {
                System.Windows.MessageBox.Show(
                    "Las contraseñas no coinciden",
                    "Error de validación",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                return false;
            }

            if (txtPassword.Text.Length < 8)
            {
                System.Windows.MessageBox.Show(
                    "La contraseña debe poseer al menos 8 caractéres",
                    "Error de validación",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                return false;
            }

            return true;
        }

        private bool UserAcceptsRegistration()
        {
            string messageBoxText   = "¿Confirma el registro del nuevo usuario?";
            string caption          = "Registrar Usuario";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon    = MessageBoxImage.Question;

            MessageBoxResult result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);

            return result == MessageBoxResult.Yes;
        }

        private void txtFileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Register_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
