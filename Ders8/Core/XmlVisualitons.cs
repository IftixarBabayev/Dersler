using Ders7;
using Ders8.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Ders8.Core
{
   public class XmlVisualitons
    {
        public void Write(Ders7.Number1 number)
        {
            FileStream file = new FileStream("Main.xml", FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(Ders7.Number1));
            xml.Serialize(file,number);
            file.Flush();
        }

    }
}
