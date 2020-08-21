﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument documento = new XmlDocument();
            XmlElement elemento = documento.CreateElement("persona");
            documento.AppendChild(elemento);
            XmlElement nombre = documento.CreateElement("nombre");
            nombre.InnerText = "Pedro";
            elemento.AppendChild(nombre);
            XmlAttribute atributo = documento.CreateAttribute("telefono");
            atributo.InnerText = "123456";
            elemento.Attributes.Append(atributo);
            XmlElement apellidos = documento.CreateElement("apellidos");
            apellidos.InnerText = "Alvarez";
            elemento.AppendChild(apellidos);
            XmlElement edad = documento.CreateElement("edad");
            edad.InnerText = "34";
            elemento.AppendChild(edad);

            nombre.InnerText = "Luis";
            elemento.AppendChild(nombre);
            atributo.InnerText = "456789";
            elemento.Attributes.Append(atributo);
            
            apellidos.InnerText = "García";
            elemento.AppendChild(apellidos);

            edad.InnerText = "40";
            elemento.AppendChild(edad);

            XmlWriter escritor = new XmlTextWriter("persona.xml", null);
            documento.Save(escritor);
            Console.ReadLine();
        }
    }
}
