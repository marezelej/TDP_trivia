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
using TP_Final.Contract;
using TP_Final.IO;
using TP_Final.Controller;

namespace TriviaGUI
{
    public partial class NewTest : Form
    {
        private UserDTO iAuthenticatedUser;
        private IQuestionsSetController iQuestionsSetController = new QuestionsSetController();

        public NewTest(UserDTO pAuthenticatedUser)
        {
            iAuthenticatedUser = pAuthenticatedUser;
            InitializeComponent();
        }

        private void NewTest_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            IEnumerable<QuestionsSetDTO> bQuestionsSets = iQuestionsSetController.GetAll();

            comboSets.Items.AddRange(bQuestionsSets.ToArray());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string messageBoxText = "¿Desea cancelar el examen?";
            string caption = "Cancelar";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;

            MessageBoxResult result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);

            if (result == MessageBoxResult.Yes)
                Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string messageBoxText = "¿Desea iniciar el examen?";
            string caption = "Iniciar";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Question;

            MessageBoxResult result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);

            if (result == MessageBoxResult.Yes)
                StartTest();
        }

        private void StartTest()
        {
            SessionDTO session = new SessionDTO();
            Test testWindow = new Test();
            testWindow.ShowDialog();
            Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
