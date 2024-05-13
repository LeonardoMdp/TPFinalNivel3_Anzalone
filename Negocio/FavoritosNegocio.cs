using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Dominio;


namespace Negocio
{
   public class FavoritosNegocio
    {
        public  void agregarFavorito(string articulo, int idUsuario)

        {
            Acceso_a_datos datos = new Acceso_a_datos();

            try
            {
                datos.Setearconsulta("INSERT INTO Favoritos (IdUsuario, IdArticulo) VALUES (@IdUsuario, @IdArticulo)");
               
                
                datos.SetearParametros("@IdArticulo",articulo);
                datos.SetearParametros("@IdUsuario", idUsuario);
                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

       public List<Articulo> ListarFavoritos(int id)
        {
            try
            {
                FavoritosNegocio negocio = new FavoritosNegocio();
                List<Articulo> listaDeFavoritos = new List<Articulo>();
                Acceso_a_datos datos = new Acceso_a_datos();

                datos.Setearconsulta("SELECT a.ImagenUrl, a.Id FROM ARTICULOS a INNER JOIN Favoritos f ON a.Id = f.IdArticulo INNER JOIN Usuarios u ON f.IdUsuario = u.Id WHERE u.Id = @id");
                datos.SetearParametros("@id",id);
                datos.Ejecutarlectura();

                while(datos.Lector.Read())
                {
                    Articulo favorito = new Articulo();

                    favorito.Imagen = (string)datos.Lector["ImagenUrl"];
                    favorito.id = (int)datos.Lector["Id"];
                    listaDeFavoritos.Add(favorito);
                }

                datos.cerrarconexion();
                return listaDeFavoritos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarfavorito (int IdArticulo, int idUsuario)
        {

            try
            {
                Acceso_a_datos datos = new Acceso_a_datos();

                datos.Setearconsulta("delete from Favoritos where IdArticulo = @IdArticulo and IdUsuario = @IdUsuario");
                datos.SetearParametros("@IdArticulo", IdArticulo);
                datos.SetearParametros("@IdUsuario",idUsuario);

                datos.ejecutaraccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
