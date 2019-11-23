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
    public partial class NewTest : Form
    {
        public NewTest()
        {
            InitializeComponent();
        }

        private void NewTest_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string messageBoxText = "¿Desea cancelar el examen?";
            string caption = "Cancelar";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;

            MessageBoxResult result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);

            if (result == MessageBoxResult.Yes)
                Close();
        }
    }
}
