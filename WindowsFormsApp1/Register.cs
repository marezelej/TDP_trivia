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

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            string messageBoxText = "¿Desea cancelar el registro?";
            string caption = "Cancelar Registro";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;

            MessageBoxResult result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);

            if(result == MessageBoxResult.Yes)
                this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            string messageBoxText = "¿Confirma el registro del nuevo usuario?";
            string caption = "Registrar Usuario";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Question;

            MessageBoxResult result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);

            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
