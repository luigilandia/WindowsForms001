using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleXML
{
    class Program6
    {
        static void Main(string[] args)
        {
            StringBuilder cadena = new StringBuilder();
            for (int i=0; i<100000; i++)
            {
                cadena.Append("hola");
                cadena.Append(i);
                cadena.Append("adios");
                cadena.Append(i);
                cadena.Append("hola2");
            }
            Console.WriteLine("terminó");
            Console.ReadLine();
        }
    }
}
