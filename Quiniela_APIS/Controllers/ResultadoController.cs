using Quiniela_APIS.Data;
using Quiniela_APIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Quiniela_APIS.Controllers
{
    public class ResultadoController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public bool Post([FromBody] Resultado oResultado)
        {
            return ResultadoData.RegistrarResultado(oResultado);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Resultado oResultado)
        {
            return ResultadoData.ModificarResultado(oResultado);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}