using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1
{
    public class FacturasController : ApiController
    {
        // GET api/<controller>
        static List<Factura> lista = new List<Factura>();
        static FacturasController()
        {
            Factura f = new Factura(1, "ordenador");
            Factura f2 = new Factura(2, "tablet");

            lista.Add(f);
            lista.Add(f2);
        }

        public IList<Factura> Get()
        {
            return lista;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] Factura factura)
        {
            lista.Add(factura);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}