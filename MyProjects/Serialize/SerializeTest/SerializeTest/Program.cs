using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TestData;
using TestData2;

namespace SerializeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewSerializer();

            Stopwatch swatch = Stopwatch.StartNew();
            XmlSerializer xs2 = new XmlSerializer(typeof(Class2));
            Class2 c2 = new Class2() { Name = "Class2", ClassInfo = new Class5() { Name = "Class5" } };
            StringBuilder sb = new StringBuilder();
            using (StringWriter sw = new StringWriter(sb) )
            {
                xs2.Serialize(sw, c2);
            }

            using (StringReader sr = new StringReader(sb.ToString()))
            {
                object obj = xs2.Deserialize(sr);
            }
            swatch.Stop();
            Console.WriteLine(swatch.Elapsed.TotalSeconds);
            Console.Read();
        }

        private static void NewSerializer()
        {
            Stopwatch sw = Stopwatch.StartNew();
            XmlSerializer xs = new XmlSerializer(typeof(Class1), new Type[] { typeof(Class2), typeof(Class3), typeof(Class4) });
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds);



            sw.Restart();
            XmlSerializer xs1 = new XmlSerializer(typeof(Class1));
            XmlSerializer xs2 = new XmlSerializer(typeof(Class2));
            XmlSerializer xs3 = new XmlSerializer(typeof(Class3));
            XmlSerializer xs4 = new XmlSerializer(typeof(Class4));
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds);
        }
    }
}
