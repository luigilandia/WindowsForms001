using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program5
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            XmlReader lector = new XmlTextReader("../../XMLFile1.xml");
            Persona p=new Persona();
            while (lector.Read())
            {
                if (lector.NodeType == XmlNodeType.Element)
                {
                    if (lector.Name.Equals("nombre"))
                    {
                        lector.Read();
                        p.Nombre = lector.Value;
                    }
                    else if (lector.Name.Equals("apellido"))
                    {
                        lector.Read();
                        p.Apellido = lector.Value;
                    }
                    else if(lector.Name.Equals("edad"))
                    {
                        lector.Read();
                        p.Edad = Convert.ToInt32(lector.Value);
                        lista.Add(p);
                        p = new Persona();
                    } 
                }
            }
            foreach (Persona per in lista)
            {
                Console.WriteLine(per.Nombre);
                Console.WriteLine(per.Apellido);
                Console.WriteLine(per.Edad);
            }
            Console.ReadLine();
        }

    }
}
