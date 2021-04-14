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
using TriviaGame.Controller;
using TriviaGame.IO;

namespace TriviaGUI
{

    public partial class Test : Form
    {
        private TriviaDTO trivia;
        private QuestionDTO currentQuestion;
        private IList<RadioButton> radios;
        private ITriviaController triviaController = new TriviaController();
        public Test(TriviaDTO pTrivia)
        {
            InitializeComponent();
            trivia = pTrivia;
            radios = new List<RadioButton> { rAnswer1, rAnswer2, rAnswer3, rAnswer4 };
        }

        private void Test_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            LoadQuestion(trivia.Questions.First());
            questionQuantityLabel.Text = trivia.Questions.Count + " preguntas";
            timeLabel.Text = trivia.TimeLimit + " seg";
            progressBar1.Maximum = trivia.Questions.Count;
            trivia.Start();
            timer1.Start();
        }

        private void LoadQuestion(QuestionDTO question)
        {
            int index = trivia.Questions.IndexOf(question);
            currentQuestion = question;
            QuestionText.Text = question.Description;
            LoadAnswers(question.Answers);
            questionGroupBox.Text = "Pregunta número " + (index + 1);
            CheckButtons(index);
        }

        private void LoadAnswers(IList<AnswerDTO> answers)
        {
            for (int i = 0; i < radios.Count; ++i)
            {
                AnswerDTO answer = answers[i];
                RadioButton radio = radios[i];
                radio.Text = answer.Description;
                radio.Checked = currentQuestion.IsSelected(answer);
            }
        }

        private void CheckButtons(int index)
        {
            clickPrevious.Enabled = true;
            clickNext.Enabled = true;
            if (index == 0)
            {
                clickPrevious.Enabled = false;
            }
            if (trivia.Questions.Count <= (index + 1))
            {
                clickNext.Enabled = false;
            }
        }

        private void clickPrevious_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            int index = trivia.Questions.IndexOf(currentQuestion) - 1;
            LoadQuestion(trivia.Questions[index]);
        }

        private void clickNext_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            int index = trivia.Questions.IndexOf(currentQuestion) + 1;
            LoadQuestion(trivia.Questions[index]);
        }

        private void clickEnd_Click(object sender, EventArgs e)
        {
            string messageBoxText = "¿Desea finalizar el examen?";
            string caption = "Finalizar";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Question;

            MessageBoxResult result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);

            if (result == MessageBoxResult.Yes)
            {
                SaveCurrentAnswer();
                trivia.Finish();
                ShowResult();
            }
        }

        private void SaveCurrentAnswer()
        {
            if (currentQuestion.SelectedAnswer == null)
                progressBar1.Value++;
            currentQuestion.SelectedAnswer = GetSelectedAnswer();
        }

        private AnswerDTO GetSelectedAnswer()
        {
            for (int i = 0; i < radios.Count; ++i)
            {
                RadioButton radio = radios[i];
                if (radio.Checked)
                {
                    return currentQuestion.Answers[i];
                }
            }
            return null;
        }
        private void ShowResult()
        {
            string messageBoxText = "Resultado\n" +
                "Respuestas correctas: " + trivia.GetCorrectQuantity() + "\n" +
                "Tiempo empleado: " + trivia.GetSecondsSpent() + " seg.'\n" + 
                "Puntaje final: " + trivia.GetFinalScore() + " puntos";
            System.Windows.MessageBox.Show(messageBoxText);
            triviaController.SaveTrivia(trivia);
            Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = trivia.GetRemainingSeconds() + " seg";
            if (trivia.GetRemainingSeconds() <= 0)
            {
                timer1.Stop();
                trivia.Finish();
                System.Windows.MessageBox.Show("Se acabó el tiempo!");
                ShowResult();
            }
        }
    }
}
