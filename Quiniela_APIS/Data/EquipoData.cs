using Quiniela_APIS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Data
{
    public class EquipoData
    {
        public static bool RegistrarEquipo(Equipo oEquipo)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("esp_registrar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@EquipoId", oEquipo.EquipoId);
                cmd.Parameters.AddWithValue("@EquipoNombre", oEquipo.EquipoNombre);
                cmd.Parameters.AddWithValue("@EquipoDescripcion", oEquipo.EquipoDescripcion);
                cmd.Parameters.AddWithValue("@EquipoRutaLogo", oEquipo.EquipoRutaLogo);

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