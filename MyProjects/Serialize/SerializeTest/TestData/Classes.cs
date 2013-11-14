using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TestData2;

namespace TestData
{
    [Serializable]
    public class Class1
    {
        public string Name { get; set; }
    }

    [Serializable]
    [XmlInclude(typeof(Class5))]
    public class Class2
    {
        public string Name { get; set; }

        public object ClassInfo { get; set; }
    }

    [Serializable]
    public class Class3
    {
        public string Name { get; set; }
    }

    [Serializable]
    public class Class4
    {
        public string Name { get; set; }
    }
}
