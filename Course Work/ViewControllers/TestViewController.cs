using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Course_Work
{
    public partial class TestViewController : Form
    {

        private static readonly Random random = new Random();

        QuestionStruct currentQuestion = new QuestionStruct();

        int questionsCount = 0;

        static int[] numbers = Enumerable.Range(1, 15).ToArray();

        int maxQuestions = 10;

        int rightAnswersCount = 0;

        int radioChosen = 0;

        public static int GenerateRandomNumber()
        {
            int randomValue = numbers[random.Next(numbers.Length)];

            return randomValue;

        }


        private void whichRadioChosen()
        {
            if (answerNumberOne.Checked)
            {
                radioChosen = 1;
            }
            else if (answerNumberTwo.Checked)
            {
                radioChosen = 2;
            }
            else if (answerNumberThree.Checked)
            {
                radioChosen = 3;
            }
            else if (answerNumberFour.Checked)
            {
                radioChosen = 4;
            }
        }

        private void isRight()
        {
            if (radioChosen == currentQuestion.correctAnswer)
            {
                rightAnswersCount++;
            }

        }

        private void clearRadio()
        {
            answerNumberOne.Checked = false;
            answerNumberTwo.Checked = false;
            answerNumberThree.Checked = false;
            answerNumberFour.Checked = false;
        }


        private void getTheQuestion(int questionNumber)
        {
            FirebaseResponse result = client.Get(@"Questions/" + questionNumber);
            QuestionStruct resultQuestion = result.ResultAs<QuestionStruct>();
            currentQuestion = resultQuestion;

            numbers = numbers.Where(n => n != questionNumber).ToArray();

            questionTextLabel.Text = resultQuestion.Question;
            answerNumberOne.Text = resultQuestion.answerOne;
            answerNumberTwo.Text = resultQuestion.answerTwo;
            answerNumberThree.Text = resultQuestion.answerThree;
            answerNumberFour.Text = resultQuestion.answerFour;

        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "y0F8Y2PZQZcrW8nyWw1B0I1n32sOLVq2zUYygd9i",
            BasePath = "https://testapp-e2de7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public TestViewController()
        {
            InitializeComponent();
        }

        public void nextButtonClicked(object sender, EventArgs e)
        {
            whichRadioChosen();
            isRight();
            questionsCount++;
            clearRadio();

            if (questionsCount < maxQuestions)
            {
                TestViewControllerLoad(sender, e);
            }
            else
            {
                MessageBox.Show("You finished the test, your result is " + rightAnswersCount);
              
                Hide();
                MainScreenViewController msvc = new MainScreenViewController();
                msvc.Closed += (s, args) => Close();
                msvc.Show();

                ResultsList result = new ResultsList(LoginViewController.firstName, LoginViewController.lastName, rightAnswersCount);

                SetResponse set = client.Set(@"Results/" + result.userFirstName + " " + result.userLastName, result);
            }

        }
        private void TestViewControllerLoad(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);

            }
            catch
            {
                MessageBox.Show("Connection problem occured");
            }

            getTheQuestion(GenerateRandomNumber());
        }
    }
}



