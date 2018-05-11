using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuizSolver
{
    public class Question
    {
        [XmlElement("questionText")]
        public string questionText;
        [XmlArray("answers")]
        [XmlArrayItem("string")]
        public string[] answers;
        [XmlArray("properAnswers")]
        [XmlArrayItem("boolean")]
        public bool[] properAnswers;

        public bool[] userAnswers;

        public Question()
        {
            this.questionText = "";
            this.answers = null;
            this.properAnswers = null;
            this.userAnswers = null;
           
        }

    }
}
