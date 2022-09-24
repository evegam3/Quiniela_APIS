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
    public class UsuarioController : ApiController
    {
        // GET api/<controller>
        public List<Usuario> Get()
        {
            return UsuarioData.ListaUsuario();
        }

        // GET api/<controller>/5
        public Usuario Get(int id)
        {
            return UsuarioData.ObtieneUsuario(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Usuario oUsuario)
        {
            return UsuarioData.RegistrarUsuario(oUsuario);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Usuario oUsuario)
        {
            return UsuarioData.ModificaUsuario(oUsuario);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return UsuarioData.EliminaUsuario(id);
        }
    }
}