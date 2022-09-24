using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Models
{
    public class Liga
    {
        public int LigaId { get; set; }
        public int TipoLigaId { get; set; }
        public int SedeId { get; set; }
        public string LigaNombre { get; set; }
        public DateTime LigaFechaInicio { get; set; }
        public DateTime LigaFechaFin { get; set; }
        public string LigaRequierePago { get; set; }
        public decimal LigaValorPago { get; set; }

    }
}