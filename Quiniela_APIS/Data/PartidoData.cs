using Quiniela_APIS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Data
{
    public class PartidoData
    {
        public static bool RegistrarPartido(Partido oPartido)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("psp_registrar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@EquipoLocalId", oPartido.EquipoLocalId);
                cmd.Parameters.AddWithValue("@EquipoVisitanteId", oPartido.EquipoVisitanteId);
                cmd.Parameters.AddWithValue("@EstadioId", oPartido.EstadioId);
                cmd.Parameters.AddWithValue("@GrupoId", oPartido.GrupoId);
                cmd.Parameters.AddWithValue("@PartidoFecha", oPartido.PartidoFecha);
                cmd.Parameters.AddWithValue("@PartidoEstatus", oPartido.PartidoEstatus);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}