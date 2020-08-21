using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program3
    {
        static void Main(string[] args)
        {
            XmlReader lector = new XmlTextReader("persona.xml");
            while (lector.Read())
            {
                if (lector.NodeType == XmlNodeType.Element)
                {
                    //Console.WriteLine(lector.Name);
                }
                if (lector.Name.Equals("edad"))
                {
                    Console.WriteLine(lector.Name);   
                }
            }
            Console.ReadLine();
        }
    }
}
