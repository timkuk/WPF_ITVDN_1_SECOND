using System;
using System.IO;
using System.Xml.Serialization;

namespace Lesson32HomeWork32_Task5
{
    public class SaveXML
    {
        public static void SaveingXML(object obj, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
            StreamWriter text = new StreamWriter(path);
            xmlSerializer.Serialize(text, obj);
            text.Close();
        }
    }
}
