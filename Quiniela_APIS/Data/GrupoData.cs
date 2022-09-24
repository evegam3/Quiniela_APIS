using Quiniela_APIS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Data
{
    public class GrupoData
    {
        public static bool RegistrarGrupo(Grupo oGrupo)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("gsp_registrar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@GrupoId", oGrupo.GrupoId);
                cmd.Parameters.AddWithValue("@LigaId", oGrupo.LigaId);
                cmd.Parameters.AddWithValue("@GrupoNombre", oGrupo.GrupoNombre);
                cmd.Parameters.AddWithValue("@GrupoNoEquiposMinimos", oGrupo.GrupoNoEquiposMinimos);
                cmd.Parameters.AddWithValue("@GrupoNoEquiposMaximos", oGrupo.GrupoNoEquiposMaximos);
                cmd.Parameters.AddWithValue("@GrupoEstatus", oGrupo.GrupoEstatus);

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


        public static bool ModificarGrupo(Grupo oGrupo)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("gsp_modificar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@GrupoId", oGrupo.GrupoId);
                cmd.Parameters.AddWithValue("@LigaId", oGrupo.LigaId);
                cmd.Parameters.AddWithValue("@GrupoNombre", oGrupo.GrupoNombre);
                cmd.Parameters.AddWithValue("@GrupoNoEquiposMinimos", oGrupo.GrupoNoEquiposMinimos);
                cmd.Parameters.AddWithValue("@GrupoNoEquiposMaximos", oGrupo.GrupoNoEquiposMaximos);
                cmd.Parameters.AddWithValue("@GrupoEstatus", oGrupo.GrupoEstatus);

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


        public static List<Grupo> ListaGrupo()
        {
            List<Grupo> oListaGrupo = new List<Grupo>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("gsp_listar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Grupo oGrupo = new Grupo();
                            oGrupo.GrupoId = Convert.ToInt32(dr["GrupoId"]);
                            oGrupo.LigaId = Convert.ToInt32(dr["LigaId"]);
                            oGrupo.GrupoNombre = dr["GrupoNombre"].ToString().Trim();
                            oGrupo.GrupoEstatus = dr["GrupoEstatus"].ToString().Trim();
                            oGrupo.GrupoNoEquiposMinimos = Convert.ToInt32(dr["GrupoNoEquiposMinimos"]);
                            oGrupo.GrupoNoEquiposMaximos = Convert.ToInt32(dr["GrupoNoEquiposMaximos"]);

                            oListaGrupo.Add(oGrupo);
                        }
                    }
                    return oListaGrupo;
                }
                catch (Exception ex)
                {
                    return oListaGrupo;
                }
            }
        }


        public static List<Grupo> ListaGrupoLiga(int idLiga)
        {
            List<Grupo> oListaGrupo = new List<Grupo>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("gsp_listarLiga", oConexion);
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
                            Grupo oGrupo = new Grupo();
                            oGrupo.GrupoId = Convert.ToInt32(dr["GrupoId"]);
                            oGrupo.LigaId = Convert.ToInt32(dr["LigaId"]);
                            oGrupo.GrupoNombre = dr["GrupoNombre"].ToString().Trim();
                            oGrupo.GrupoEstatus = dr["GrupoEstatus"].ToString().Trim();
                            oGrupo.GrupoNoEquiposMinimos = Convert.ToInt32(dr["GrupoNoEquiposMinimos"]);
                            oGrupo.GrupoNoEquiposMaximos = Convert.ToInt32(dr["GrupoNoEquiposMaximos"]);

                            oListaGrupo.Add(oGrupo);
                        }
                    }
                    return oListaGrupo;
                }
                catch (Exception ex)
                {
                    return oListaGrupo;
                }
            }
        }

        public static Grupo ObtieneGrupo(int idGrupo)
        {
            Grupo oGrupo = new Grupo();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("gsp_obtener", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@GrupoId", idGrupo);
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oGrupo.GrupoId = Convert.ToInt32(dr["GrupoId"]);
                            oGrupo.LigaId = Convert.ToInt32(dr["LigaId"]);
                            oGrupo.GrupoNombre = dr["GrupoNombre"].ToString().Trim();
                            oGrupo.GrupoEstatus = dr["GrupoEstatus"].ToString().Trim();
                            oGrupo.GrupoNoEquiposMinimos = Convert.ToInt32(dr["GrupoNoEquiposMinimos"]);
                            oGrupo.GrupoNoEquiposMaximos = Convert.ToInt32(dr["GrupoNoEquiposMaximos"]);

                        }
                    }
                    return oGrupo;
                }
                catch (Exception ex)
                {
                    return oGrupo;
                }
            }
        }

        public static bool EliminaGrupo(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("gsp_eliminar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@GrupoId", id);
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