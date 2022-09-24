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
    public class GrupoController : ApiController
    {
        // GET api/<controller>
        public List<Grupo> Get()
        {
            return GrupoData.ListaGrupo();
        }

        public List<Grupo> Options(int id)
        {
            return GrupoData.ListaGrupoLiga(id);
        }

        // GET api/<controller>/5
        public Grupo Get(int id)
        {
            return GrupoData.ObtieneGrupo(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Grupo oGrupo)
        {
            return GrupoData.RegistrarGrupo(oGrupo);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Grupo oGrupo)
        {
            return GrupoData.ModificarGrupo(oGrupo);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return GrupoData.EliminaGrupo(id);
        }
    }
}