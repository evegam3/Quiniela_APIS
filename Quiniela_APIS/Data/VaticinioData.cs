using Quiniela_APIS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Data
{
    public class VaticinioData
    {
        public static bool RegistrarVaticinio(Vaticinio oVaticinio)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("vsp_registrar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PartidoId", oVaticinio.PartidoId);
                cmd.Parameters.AddWithValue("@VaticinioGolesEquipoLocal", oVaticinio.VaticinioGolesEquipoLocal);
                cmd.Parameters.AddWithValue("@VaticinioGolesEquipoVisitante", oVaticinio.VaticinioGolesEquipoVisitante);
                cmd.Parameters.AddWithValue("@VaticinioEstatus", oVaticinio.VaticinioEstatus);
                cmd.Parameters.AddWithValue("@UsuarioId", oVaticinio.UsuarioId);
                cmd.Parameters.AddWithValue("@VaticinioPuntosObtenidos", oVaticinio.VaticinioPuntosObtenidos);

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

        public static bool ModificarVaticinio(Vaticinio oVaticinio)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("vsp_modificar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@VaticinioId", oVaticinio.PartidoId);
                cmd.Parameters.AddWithValue("@PartidoId", oVaticinio.PartidoId);
                cmd.Parameters.AddWithValue("@VaticinioGolesEquipoLocal", oVaticinio.VaticinioGolesEquipoLocal);
                cmd.Parameters.AddWithValue("@VaticinioGolesEquipoVisitante", oVaticinio.VaticinioGolesEquipoVisitante);
                cmd.Parameters.AddWithValue("@VaticinioEstatus", oVaticinio.VaticinioEstatus);
                cmd.Parameters.AddWithValue("@UsuarioId", oVaticinio.UsuarioId);
                cmd.Parameters.AddWithValue("@VaticinioPuntosObtenidos", oVaticinio.VaticinioPuntosObtenidos);

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