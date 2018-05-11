using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuizSolver
{
    [XmlRoot("ArrayOfQuestion")]
    public class ArrayOfQuestion
    {
        [XmlElement("Question")]
        public  List<Question> questionList;
        

        ArrayOfQuestion()
        {
            questionList = new List<Question>();
        }
       

        public Question[] ToArray() => questionList.ToArray();

    }
}
