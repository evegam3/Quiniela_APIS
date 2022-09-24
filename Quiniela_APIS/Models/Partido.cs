using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Models
{
    public class Partido
    {
        public int PartidoId { get; set; }
        public int EquipoLocalId { get; set; }
        public int EquipoVisitanteId { get; set; }
        public int EstadioId { get; set; }
        public int GrupoId { get; set; }
        public DateTime PartidoFecha{ get; set; }
        public string PartidoEstatus { get; set; }
       
    }
}