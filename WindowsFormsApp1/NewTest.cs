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
using TriviaGame;
using TriviaGame.Contract;
using TriviaGame.IO;
using TriviaGame.Controller;
using TriviaGUI.Modal;
using TriviaGame.Error.General;

namespace TriviaGUI
{
    public partial class NewTest : Form
    {
        static int cDefaultQuantity = 10;
        private UserDTO iAuthenticatedUser;
        private IQuestionsSetController questionsSetController = new QuestionsSetController();
        private ITriviaController triviaController = new TriviaController();

        public NewTest(UserDTO pAuthenticatedUser)
        {
            iAuthenticatedUser = pAuthenticatedUser;
            InitializeComponent();
        }

        private void NewTest_Load(object sender, EventArgs eventArgs)
        {
            CenterToScreen();

            try
            {
                IEnumerable<QuestionsSetDTO> bQuestionsSets = questionsSetController.GetAll();
                comboSets.Items.AddRange(bQuestionsSets.ToArray());
                if (bQuestionsSets.Count() == 1)
                {
                    comboSets.SelectedIndex = 0;
                }
            } catch(Exception e)
            {
                Console.WriteLine(e);
                ErrorModal.Show("Ocurrió un error obteniendo los conjuntos de preguntas. Por favor, reintentar...");
                Close();
                return;
            }

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
            TriviaDTO bTrivia;
            try
            {
                bTrivia = triviaController.CreateTrivia(
                    iAuthenticatedUser,
                    (QuestionsSetDTO)comboSets.SelectedItem,
                    (CategoryDTO)comboCategory.SelectedItem,
                    (DiffucultyDTO)comboDifficulty.SelectedItem,
                    (int)numQuantity.Value
                    );
            }
            catch (NoResultsException e)
            {
                System.Console.WriteLine(e);
                System.Windows.MessageBox.Show(
                    "No hay preguntas para las opciones seleccionadas. Por favor, seleccionar otras opciones y reintentar...",
                    "No hay información",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                return;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                System.Windows.MessageBox.Show(
                    "Ocurrió un error inesperado. Por favor, reintentar...",
                    "Error de comunicación",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
                return;
            }
            Test testWindow = new Test(bTrivia);
            testWindow.ShowDialog();
            Close();
        }

        private void comboSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCategory.Items.Clear();
            comboDifficulty.Items.Clear();

            QuestionsSetDTO bSelectedSet = comboSets.SelectedItem as QuestionsSetDTO;

            comboCategory.Items.AddRange(bSelectedSet.Categories.ToArray());
            comboDifficulty.Items.AddRange(bSelectedSet.Difficulties.ToArray());

            numQuantity.Value = cDefaultQuantity;

            if (bSelectedSet.Categories.Count() > 0)
                comboCategory.SelectedIndex = 0;

            if (bSelectedSet.Difficulties.Count() > 0)
                comboDifficulty.SelectedIndex = 0;
        }
    }
}
