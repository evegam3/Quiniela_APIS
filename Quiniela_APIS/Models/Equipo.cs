using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Models
{
    public class Equipo
    {
        public int EquipoId { get; set; }
        public string EquipoNombre { get; set; }
        public string EquipoDescripcion { get; set; }
        public string EquipoRutaLogo { get; set; }
    }
}