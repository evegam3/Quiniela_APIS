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
    public class LigaController : ApiController
    {
        // GET api/<controller>
        public List<Liga> Get()
        {
            return LigaData.ListaLiga();
        }

        // GET api/<controller>/5
        public Liga Get(int id)
        {
            return LigaData.ObtieneLiga(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Liga oLiga)
        {
            return LigaData.RegistrarLiga(oLiga); 
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Liga oLiga)
        {
            return LigaData.ModificarLiga(oLiga); 
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return LigaData.EliminaLiga(id);
        }
    }
}