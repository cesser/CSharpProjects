using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlParser parser = new XmlParser();
            //string xml = parser.ReadConfiguration("app.ApplicationConfiguration.cfg");

            //XmlSerializer xs = new XmlSerializer(typeof(ApplicationConfiguration));
            //using (StringReader sr = new StringReader("<ApplicationConfiguration>" + xml + "</ApplicationConfiguration>"))
            //{
            //    object obj = xs.Deserialize(sr);
            //}

            var result =  parser.ReadConfigurationAsync("app.ApplicationConfiguration.cfg");

            int i = 100;
            while (i-- > 0)
            {
                Console.Write(i + ",");
            }
            while(true)
            {
                string input = Console.ReadLine();
                Console.WriteLine(input);
            }
           
            
        }
    }
}
