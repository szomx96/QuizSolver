using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSolver
{
    public partial class View : Form
    {

        private ArrayOfQuestion questionArray;
        int currentQuestionID;      
        
        

        public View()
        {
            InitializeComponent();

        }

        private void checkScore()
        {
            Question[] arrayQ = questionArray.ToArray();
            int userScore = 0;

            foreach (Question q in arrayQ) {

                if (q.userAnswers != null)
                {
                    for (int i = 0; i < q.properAnswers.Length; i++)
                    {

                        if (q.properAnswers[i] == true && q.userAnswers[i] == true)
                        {
                            userScore++;
                        }
                    }
                }
            }

            textBoxScore.Text = "Your score: " + userScore + "/" + maxScore();

        }


        private void clearSelectedAnswers()
        {
            Question[] arrayQ = questionArray.ToArray();

            if (arrayQ[currentQuestionID].userAnswers != null)
            {
                answer1.IsChecked = arrayQ[currentQuestionID].userAnswers[0];
                answer2.IsChecked = arrayQ[currentQuestionID].userAnswers[1];
                answer3.IsChecked = arrayQ[currentQuestionID].userAnswers[2];
                answer4.IsChecked = arrayQ[currentQuestionID].userAnswers[3];
            }
            else
            {
                answer1.IsChecked = false;
                answer2.IsChecked = false;
                answer3.IsChecked = false;
                answer4.IsChecked = false;

            }

        }

        private void clearThemAll()
        {
            listBoxQuestions.Items.Clear();
            textBoxScore.Clear();
            textBox1.Clear();
            answer1.IsChecked = false;
            answer2.IsChecked = false;
            answer3.IsChecked = false;
            answer4.IsChecked = false;

        }

        private void SaveAnswer()
        {
            Question[] arrayQ = questionArray.ToArray();

            if (arrayQ[currentQuestionID].userAnswers == null)
            {
                bool[] temp = new bool[arrayQ[currentQuestionID].properAnswers.Length];


                arrayQ[currentQuestionID].userAnswers = temp;
            }
            else
            {
                for(int i = 0; i < arrayQ[currentQuestionID].properAnswers.Length; i++)
                {
                    arrayQ[currentQuestionID].userAnswers[i] = false;
                }
            }         

            if (answer1.IsChecked) arrayQ[currentQuestionID].userAnswers[0] = true;
            if (answer2.IsChecked) arrayQ[currentQuestionID].userAnswers[1] = true;
            if (answer3.IsChecked) arrayQ[currentQuestionID].userAnswers[2] = true;
            if (answer4.IsChecked) arrayQ[currentQuestionID].userAnswers[3] = true;

        }

        private void loadQuestion(int index)
        {
            Question[] arrayQ = questionArray.ToArray();
            currentQuestionID = index;

            

            textBox1.Text = arrayQ[index].questionText;
            answer1.AnswerText = arrayQ[index].answers[0];
            answer2.AnswerText = arrayQ[index].answers[1];
            answer3.AnswerText = arrayQ[index].answers[2];
            answer4.AnswerText = arrayQ[index].answers[3];

            clearSelectedAnswers();


        }

        private void fillListBox()
        {
            Question[] arrayQ = questionArray.ToArray();

            for (int i = 0; i < arrayQ.Length; i++)
            {
                listBoxQuestions.Items.Add(i+1);
            }

        }

        private int maxScore()
        {
            Question[] arrayQ = questionArray.ToArray();
            int maxScore = 0;

            foreach (Question q in arrayQ)
            {
                foreach(bool answer in q.properAnswers)
                {
                    if(answer == true) { maxScore++; }
                }
            }           
            return maxScore;
        }


        private void buttonImport_Click(object sender, EventArgs e)
        {
            clearThemAll();

            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;

            if (path == "openFileDialog1")
            {
                return;
                
            }else if (!path.EndsWith(".xml")) { 
                
                MessageBox.Show("To nie jest plik .xml", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            questionArray = LoadXML.LoadData(path);                       
            
            if(questionArray!= null)
            {
                fillListBox();
                loadQuestion(0);
                maxScore();
            }
            
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            loadQuestion(listBoxQuestions.SelectedIndex);
            
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentQuestionID > 0)
            {
                loadQuestion(currentQuestionID - 1);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Question[] qArray = questionArray.ToArray();

            if (currentQuestionID < qArray.Length-1)
            {
                SaveAnswer();
                loadQuestion(currentQuestionID + 1);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            MessageBox.Show("Answer confirmed");
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            checkScore();

        }
    }
}
