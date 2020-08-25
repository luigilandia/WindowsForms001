using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1
{
    public class WebAPIController : ApiController
    {
        // GET api/<controller>
        public IList<Factura> Get()
        {
            Factura f = new Factura(1, "ordenador");
            Factura f2 = new Factura(2, "tablet");
            List<Factura> lista = new List<Factura>();
            lista.Add(f);
            lista.Add(f2);
            return lista;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
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