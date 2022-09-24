using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Models
{
    public class Grupo
    {
        public int GrupoId { get; set; }
        public int LigaId { get; set; }
        public string GrupoNombre { get; set; }
        public int GrupoNoEquiposMinimos { get; set; }
        public int GrupoNoEquiposMaximos { get; set; }
        public string GrupoEstatus { get; set; }
    }
}