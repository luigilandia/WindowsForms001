using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleXML
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public Persona()
        {

        }

        public override string ToString()
        {
            return "nombre: "+Nombre+", apellido: "+Apellido+", edad: "+Edad;
        }
    }
}
