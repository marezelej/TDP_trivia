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
    }
}
