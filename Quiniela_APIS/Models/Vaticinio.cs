using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Models
{
    public class Vaticinio
    {
        public int VaticinioId { get; set; }
        public int PartidoId { get; set; }
        public int VaticinioGolesEquipoLocal { get; set; }
        public int VaticinioGolesEquipoVisitante { get; set; }
        public int VaticinioPuntosObtenidos { get; set; }
        public int UsuarioId { get; set; }
        public string VaticinioEstatus { get; set; }
    }
}