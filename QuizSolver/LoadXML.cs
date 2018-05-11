using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace QuizSolver
{
    public class LoadXML
    {

        public static ArrayOfQuestion LoadData(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ArrayOfQuestion));

            FileStream fs = new FileStream(path, FileMode.Open);
            ArrayOfQuestion result = (ArrayOfQuestion)serializer.Deserialize(fs);

            fs.Close();

            return result;
        }

  
    


    }
}
