using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioApellido { get; set; }
        public string UsuarioEmail { get; set; }    
        public string UsuarioPassword { get; set; }
        public string UsuarioEstado { get; set; }
        public int InvitacionId { get; set; }
    }
}