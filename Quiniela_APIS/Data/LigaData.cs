using Quiniela_APIS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Data
{
    public class LigaData
    {
        public static bool RegistrarLiga(Liga oLiga)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("lsp_registrar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@LigaId", oLiga.LigaId);
                cmd.Parameters.AddWithValue("@TipoLigaId", oLiga.TipoLigaId);
                cmd.Parameters.AddWithValue("@SedeId", oLiga.SedeId);
                cmd.Parameters.AddWithValue("@LigaNombre", oLiga.LigaNombre);
                cmd.Parameters.AddWithValue("@LigaFechaInicio", oLiga.LigaFechaFin);
                cmd.Parameters.AddWithValue("@LigaFechaFin", oLiga.LigaFechaFin);
                cmd.Parameters.AddWithValue("@LigaRequierePago", oLiga.LigaRequierePago);
                cmd.Parameters.AddWithValue("@LigaValorPago", oLiga.LigaValorPago);

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

        public static bool ModificarLiga(Liga oLiga)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("lsp_modificar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@LigaId", oLiga.LigaId);
                cmd.Parameters.AddWithValue("@TipoLigaId", oLiga.TipoLigaId);
                cmd.Parameters.AddWithValue("@SedeId", oLiga.SedeId);
                cmd.Parameters.AddWithValue("@LigaNombre", oLiga.LigaNombre);
                cmd.Parameters.AddWithValue("@LigaFechaInicio", oLiga.LigaFechaFin);
                cmd.Parameters.AddWithValue("@LigaFechaFin", oLiga.LigaFechaFin);
                cmd.Parameters.AddWithValue("@LigaRequierePago", oLiga.LigaRequierePago);
                cmd.Parameters.AddWithValue("@LigaValorPago", oLiga.LigaValorPago);

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


        public static List<Liga> ListaLiga()
        {
            List<Liga> oListaLiga = new List<Liga>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("lsp_listar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Liga oLiga= new Liga();
                            oLiga.LigaId = Convert.ToInt32(dr["LigaId"]);
                            oLiga.TipoLigaId= Convert.ToInt32(dr["TipoLigaId"]);
                            oLiga.SedeId = Convert.ToInt32(dr["SedeId"]);
                            oLiga.LigaNombre= dr["LigaNombre"].ToString().Trim();
                            oLiga.LigaFechaInicio = Convert.ToDateTime(dr["LigaFechaInicio"]);
                            oLiga.LigaFechaFin = Convert.ToDateTime(dr["LigaFechaFin"]);
                            oLiga.LigaRequierePago = dr["LigaRequierePago"].ToString().Trim(); ;
                            oLiga.LigaValorPago = Convert.ToDecimal(dr["LigaValorPago"]);
                            oListaLiga.Add(oLiga);
                        }
                    }
                    return oListaLiga;
                }
                catch (Exception ex)
                {
                    return oListaLiga;
                }
            }
        }

        public static Liga ObtieneLiga(int idLiga)
        {
            Liga oLiga = new Liga();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("lsp_obtener", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@LigaId", idLiga);
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLiga.LigaId = Convert.ToInt32(dr["LigaId"]);
                            oLiga.TipoLigaId = Convert.ToInt32(dr["TipoLigaId"]);
                            oLiga.SedeId = Convert.ToInt32(dr["SedeId"]);
                            oLiga.LigaNombre = dr["LigaNombre"].ToString().Trim();
                            oLiga.LigaFechaInicio = Convert.ToDateTime(dr["LigaFechaInicio"]);
                            oLiga.LigaFechaFin = Convert.ToDateTime(dr["LigaFechaFin"]);
                            oLiga.LigaRequierePago = dr["LigaRequierePago"].ToString().Trim(); ;
                            oLiga.LigaValorPago = Convert.ToDecimal(dr["LigaValorPago"]);
                           
                        }
                    }
                    return oLiga;
                }
                catch (Exception ex)
                {
                    return oLiga;
                }
            }
        }

        public static bool EliminaLiga(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("lsp_eliminar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@LigaId", id);
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