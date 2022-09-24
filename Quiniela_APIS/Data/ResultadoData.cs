using Quiniela_APIS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Data
{
    public class ResultadoData
    {
        public static bool RegistrarResultado(Resultado oResultado)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("rsp_registrar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PartidoId", oResultado.PartidoId);
                cmd.Parameters.AddWithValue("@ResultadoGolesEquipoLocal", oResultado.ResultadoGolesEquipoLocal);
                cmd.Parameters.AddWithValue("@ResultadoGolesEquipoVisitante", oResultado.ResultadoGolesEquipoVisitante);
                cmd.Parameters.AddWithValue("@ResultadoEstatus", oResultado.ResultadoEstatus);

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


        public static bool ModificarResultado(Resultado oResultado)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("rsp_modificar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ResultadoId", oResultado.ResultadoId);
                cmd.Parameters.AddWithValue("@PartidoId", oResultado.PartidoId);
                cmd.Parameters.AddWithValue("@ResultadoGolesEquipoLocal", oResultado.ResultadoGolesEquipoLocal);
                cmd.Parameters.AddWithValue("@ResultadoGolesEquipoVisitante", oResultado.ResultadoGolesEquipoVisitante);
                cmd.Parameters.AddWithValue("@ResultadoEstatus", oResultado.ResultadoEstatus);

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