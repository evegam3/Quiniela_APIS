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
    public class VaticinioController : ApiController
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

        public bool Post([FromBody] Vaticinio oVaticinio)
        {
            return VaticinioData.RegistrarVaticinio(oVaticinio);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Vaticinio oVaticinio)
        {
            return VaticinioData.ModificarVaticinio(oVaticinio);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}