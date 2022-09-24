using Quiniela_APIS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Quiniela_APIS.Data
{
    public class UsuarioData
    {
        public static bool RegistrarUsuario(Usuario oUsuario) {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_registrar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UsuarioId", oUsuario.UsuarioId);
                cmd.Parameters.AddWithValue("@UsuarioNombre", oUsuario.UsuarioNombre);
                cmd.Parameters.AddWithValue("@UsuarioApellido", oUsuario.UsuarioApellido);
                cmd.Parameters.AddWithValue("@UsuarioPassword", oUsuario.UsuarioPassword);
                cmd.Parameters.AddWithValue("@UsuarioEstado", oUsuario.UsuarioEstado);
                cmd.Parameters.AddWithValue("@UsuarioEmail", oUsuario.UsuarioEmail);
                cmd.Parameters.AddWithValue("@InvitacionId", oUsuario.InvitacionId);
                
                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception ex) {
                    return false;
                }
            }
        }


        public static bool ModificaUsuario(Usuario oUsuario)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_modificar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UsuarioId", oUsuario.UsuarioId);
                cmd.Parameters.AddWithValue("@UsuarioNombre", oUsuario.UsuarioNombre);
                cmd.Parameters.AddWithValue("@UsuarioApellido", oUsuario.UsuarioApellido);
                cmd.Parameters.AddWithValue("@UsuarioPassword", oUsuario.UsuarioPassword);
                cmd.Parameters.AddWithValue("@UsuarioEstado", oUsuario.UsuarioEstado);
                cmd.Parameters.AddWithValue("@UsuarioEmail", oUsuario.UsuarioEmail);
                cmd.Parameters.AddWithValue("@InvitacionId", oUsuario.InvitacionId);
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


        public static List<Usuario> ListaUsuario()
        {
            List<Usuario> oListaUsuario = new List<Usuario>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_listar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Usuario oUsuario = new Usuario();
                            oUsuario.UsuarioId = Convert.ToInt32(dr["UsuarioId"]);
                            oUsuario.UsuarioEstado = dr["UsuarioEstado"].ToString().Trim();
                            oUsuario.UsuarioEmail = dr["UsuarioEmail"].ToString().Trim();
                            oUsuario.UsuarioPassword = dr["UsuarioPassword"].ToString().Trim();
                            oUsuario.UsuarioApellido = dr["UsuarioApellido"].ToString().Trim();
                            oUsuario.UsuarioNombre = dr["UsuarioNombre"].ToString().Trim();
                            oUsuario.InvitacionId = Convert.ToInt32(dr["InvitacionId"]);
                            oListaUsuario.Add(oUsuario);
                        }
                    }
                    return oListaUsuario;
                }
                catch (Exception ex)
                {
                    return oListaUsuario;
                }
               
            }
        }


        public static Usuario ObtieneUsuario(int idUsuario)
        {
            Usuario rUsuario = new Usuario();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_obtener", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UsuarioId",idUsuario);
                try
                {
                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                           
                            rUsuario.UsuarioId = Convert.ToInt32(dr["UsuarioId"]);
                            rUsuario.UsuarioEstado = dr["UsuarioEstado"].ToString().Trim();
                            rUsuario.UsuarioEmail = dr["UsuarioEmail"].ToString().Trim();
                            rUsuario.UsuarioPassword = dr["UsuarioPassword"].ToString().Trim();
                            rUsuario.UsuarioApellido = dr["UsuarioApellido"].ToString().Trim();
                            rUsuario.UsuarioNombre = dr["UsuarioNombre"].ToString().Trim();
                            rUsuario.InvitacionId = Convert.ToInt32(dr["InvitacionId"]);
                            
                        }
                    }
                    return rUsuario;
                }
                catch (Exception ex)
                {
                    return rUsuario;
                }

            }
        }


        public static bool EliminaUsuario(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_eliminar", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UsuarioId", id);
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