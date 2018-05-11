using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSolver
{
    public partial class Answer : UserControl
    {
        public Answer()
        {
            InitializeComponent();
        }

        public string AnswerText
        {
            set { textBoxAnswer.Text = value; }

        }

        public bool IsChecked
        {
            get { return checkBoxAnswer.Checked; }
            set { checkBoxAnswer.Checked = value; }
        }

        public bool IsEnabled
        {
            get { return checkBoxAnswer.Enabled; }
            set { checkBoxAnswer.Enabled = value; }
        }
    }
}
