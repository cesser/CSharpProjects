using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLParser
{
    public class XmlParser
    {
        public async Task< IEnumerable<Tuple<string, string>>> ReadConfigurationAsync(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                var result  =  await TestReader(sr);

                foreach (var item in result)
                {
                    Console.WriteLine("Type: {0}, Value: {1}", item.Item1, item.Item2);
                }
                return result;
            }

        }

        public string ReadConfiguration(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                using (XmlReader reader = XmlReader.Create(sr) )
                {

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "anyType")
                        {
                            return reader.ReadInnerXml();
                        }
                    }
                    
                }
            }

            return string.Empty;
        }


        async Task<IEnumerable<Tuple<string, string>>> TestReader(StreamReader stream)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Async = true;

            IList<Tuple<string, string>> result = new List<Tuple<string, string>>();

            using (XmlReader reader = XmlReader.Create(stream, settings))
            {
                while (await reader.ReadAsync())
                {
                    #region
                    //switch (reader.NodeType)
                    //{
                    //    case XmlNodeType.Element:
                    //        Console.WriteLine("Start Element {0}", reader.Name);
                    //        break;
                    //    case XmlNodeType.Text:
                    //        Console.WriteLine("Text Node: {0}",
                    //                 await reader.GetValueAsync());
                    //        break;
                    //    case XmlNodeType.EndElement:
                    //        Console.WriteLine("End Element {0}", reader.Name);
                    //        break;
                    //    default:
                    //        Console.WriteLine("Other node {0} with value {1}",
                    //                        reader.NodeType, reader.Value);
                    //        break;
                    //}
                    #endregion
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name.Equals("anytype", StringComparison.OrdinalIgnoreCase))
                        {
                            reader.MoveToFirstAttribute();
                            if (reader.ReadAttributeValue())
                            {
                                string type = reader.Value;
                                reader.MoveToElement();
                                string configurationXmlString = await reader.ReadInnerXmlAsync();
                                //var nextContent = await reader.MoveToContentAsync();
                                //if (nextContent == XmlNodeType.Element)
                                //{
                                //    string configurationXmlString = await reader.ReadInnerXmlAsync();

                                //  
                                //}

                                result.Add(new Tuple<string, string>(type, configurationXmlString));
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
