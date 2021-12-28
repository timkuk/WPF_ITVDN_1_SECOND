using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson32HomeWork32_Task4
{
    public class SaveXML
    {
        public static void SaveingXML(object obj,string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
            TextWriter text = new StreamWriter(path);
            xmlSerializer.Serialize(text, obj);
            text.Close();
        }
    }
}
