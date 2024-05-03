using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;


namespace Negocio
{
    public class UsuarioNegocio
    {
        public bool Loguear(Usuario Usuario)
        {
            try
            {
                Acceso_a_datos datos = new Acceso_a_datos();
                datos.Setearconsulta("select Usuario, pass, Email, ImagenDePerfil, Id, TipoUser, Apellido, FechadeNacimiento from Usuarios where Usuario=@Usuario and Pass=@Pass");
                datos.SetearParametros("@Usuario", Usuario.User);
                datos.SetearParametros("@pass", Usuario.Pass);

                datos.Ejecutarlectura();

                while (datos.Lector.Read())
                {
                    Usuario.Id = (int)datos.Lector["Id"];


                    Usuario.TipoUsuario = (int)datos.Lector["TipoUser"] == 2 ? TipoUsuario.admin : TipoUsuario.Normal;

                    if (!(datos.Lector["ImagendePerfil"] is DBNull))
                    {
                        Usuario.ImagendePerfil = (string)datos.Lector["ImagendePerfil"];
                    }

                    if (!(datos.Lector["apellido"] is DBNull))
                    {
                        Usuario.Apellido = (string)datos.Lector["Apellido"];
                    }

                    if (!(datos.Lector["Email"] is DBNull))
                    {
                        Usuario.Email = (string)datos.Lector["Email"];
                    }
                    if(!(datos.Lector["fechadeNacimiento"] is DBNull))
                    {
                        Usuario.FechaDeNacimiento = DateTime.Parse(datos.Lector["fechadeNacimiento"].ToString());
                    }
                  
                    if(!(datos.Lector["Usuario"] is DBNull))
                    {
                        Usuario.User = (string)datos.Lector["Usuario"];
                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int insertarNuevo(Usuario nuevo)
        {
            Acceso_a_datos datos = new Acceso_a_datos();

            try
            {
                datos.setearProcedimiento("insertarNuevo");
                datos.SetearParametros("@email", nuevo.Email);
                datos.SetearParametros("@pass", nuevo.Pass);
                return datos.ejecutaraccionScalar();


            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }
        public void Actualizar(Usuario usuario)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {
                datos.Setearconsulta("update Usuarios set ImagendePerfil = @Imagen, Usuario=@Usuario, Apellido = @Apellido, FechadeNacimiento = @fecha where Id = @id");
                datos.SetearParametros("@Imagen", usuario.ImagendePerfil != null ? usuario.ImagendePerfil : "");
                datos.SetearParametros("@id", usuario.Id);
                datos.SetearParametros("@Usuario", usuario.User);
                datos.SetearParametros("@Apellido", usuario.Apellido);
                datos.SetearParametros("@fecha", usuario.FechaDeNacimiento);
                datos.ejecutaraccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }
    }

}
