using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Models
{
    public class Resultado
    {
        public int ResultadoId { get; set; }
        public int PartidoId { get; set; }
        public int ResultadoGolesEquipoLocal { get; set; }
        public int ResultadoGolesEquipoVisitante { get; set; }
        public string ResultadoEstatus { get; set; }
    }
}