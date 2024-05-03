using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;





namespace Negocio

{
    public class ArticuloNegocio
    {
        public object MessageBox { get; private set; }

        public List<Articulo> Listar(string id = "")
        {
            List<Articulo> Lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader Lector;


            try
            {

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select codigo, Nombre, A.Descripcion, ImagenUrl,a.precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdCategoria, A.IdMarca, A.Id from ARTICULOS A, MARCAS M , CATEGORIAS C where  A.IdMarca = M.Id and A.IdCategoria = C.Id ";
                comando.Connection = conexion;

                if (id != "")
                {
                    comando.CommandText += " and A.id= " + id;
                }

                conexion.Open();
                Lector = comando.ExecuteReader();

                while (Lector.Read())
                {
                    Articulo aux = new Articulo();

                    if (!(Lector["Codigo"] is DBNull))
                        aux.CodArt = (string)Lector["Codigo"];

                    if (!(Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)Lector["Nombre"];

                    if (!(Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)Lector["Descripcion"];

                    if (!(Lector["Imagenurl"] is DBNull))
                        aux.Imagen = (string)Lector["Imagenurl"];

                    if (!(Lector["Precio"] is DBNull))
                        aux.Precio = Lector.GetDecimal(Lector.GetOrdinal("precio"));

                    aux.Marca = new Talle();
                    if (!(Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)Lector["Marca"];

                    aux.Categoria = new Cat();
                    if (!(Lector["Categoria"] is DBNull))
                        aux.Categoria.Descripcion = (string)Lector["Categoria"];


                    if (!(Lector["Marca"] is DBNull))
                        aux.Marca.Id = (int)Lector["IdMarca"];

                    if (!(Lector["Categoria"] is DBNull))
                        aux.Categoria.Id = (int)Lector["IdCategoria"];

                    if (!(Lector["Id"] is null))
                        aux.id = (int)Lector["Id"];


                    Lista.Add(aux);
                }


                conexion.Close();
                return Lista;

            }

            catch (Exception ex)
            {

                throw ex;
            }




        }
        public List<Articulo> ListarConSP()
        {
            List<Articulo> lista = new List<Articulo>();
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {
                string Consulta = "select codigo, Nombre, A.Descripcion, ImagenUrl,a.precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdCategoria, A.IdMarca, A.Id , A.Activo from ARTICULOS A, MARCAS M , CATEGORIAS C where  A.IdMarca = M.Id and A.IdCategoria = C.Id  ";

                datos.Setearconsulta(Consulta);
                datos.Ejecutarlectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.CodArt = (string)datos.Lector["Codigo"];

                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];

                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["Imagenurl"] is DBNull))
                        aux.Imagen = (string)datos.Lector["Imagenurl"];

                    //if (!(datos.Lector["Precio"] is DBNull))
                    //    aux.Precio = datos.Lector.GetDecimal(datos.Lector.GetOrdinal("precio"));
                    if (!(datos.Lector["Precio"] is DBNull))
                    {
                        decimal precioConDecimales = datos.Lector.GetDecimal(datos.Lector.GetOrdinal("precio"));
                        int precioSinDecimales = (int)Math.Floor(precioConDecimales);
                        aux.Precio = precioSinDecimales;
                    }


                    aux.Marca = new Talle();
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Cat();
                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];


                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];

                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];

                    if (!(datos.Lector["Id"] is null))
                        aux.id = (int)datos.Lector["Id"];

                    if (!(datos.Lector["Activo"] is DBNull))
                        aux.activo = (bool)datos.Lector["Activo"];


                    lista.Add(aux);

                }

                return lista;

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

        public void ModificarconSp(Articulo nuevo)
        {
            Acceso_a_datos datos = new Acceso_a_datos();

            try
            {
                datos.setearProcedimiento("ModificarconSp");
                datos.SetearParametros("@codigo", nuevo.CodArt);
                datos.SetearParametros("@nombre", nuevo.Nombre);
                datos.SetearParametros("@descripcion", nuevo.Descripcion);
                datos.SetearParametros("@IdMarca", nuevo.Marca.Id);
                datos.SetearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.SetearParametros("@Imagenurl", nuevo.Imagen);
                datos.SetearParametros("@precio", nuevo.Precio);
                datos.SetearParametros("@Id", nuevo.id);

                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            datos.cerrarconexion();
        }

        public void agregar(Articulo nuevo)
        {
            Acceso_a_datos datos = new Acceso_a_datos();

            try
            {

                datos.Setearconsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria, ImagenUrl) VALUES (@Codigo,'" + nuevo.Nombre + "','" + nuevo.Descripcion + "'," + nuevo.Precio + ", @IdMarca, @IdCategoria, @ImagenUrl)");
                datos.SetearParametros("@Codigo", nuevo.CodArt);
                datos.SetearParametros("@IdMarca", nuevo.Marca.Id);
                datos.SetearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.SetearParametros("@ImagenUrl", nuevo.Imagen);
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

        public void agregarconSp(Articulo nuevo)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            //            @codigo varchar(50),
            //@nombre varchar(50),
            //@descripcion varchar(150),
            //@idmarca int,
            //@idcategoria int,
            //@imagenurl varchar(100),
            //@precio money

            try
            {
                datos.setearProcedimiento("SpaltaProducto");
                datos.SetearParametros("@codigo", nuevo.CodArt);
                datos.SetearParametros("@nombre", nuevo.Nombre);
                datos.SetearParametros("@descripcion", nuevo.Descripcion);
                datos.SetearParametros("@idmarca", nuevo.Marca.Id);
                datos.SetearParametros("@idcategoria", nuevo.Categoria.Id);
                datos.SetearParametros("@imagenurl", nuevo.Imagen);
                datos.SetearParametros("@precio", nuevo.Precio);
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
        public List<Articulo> Filtrar(string campo, string criterio, string filtro, string estado)
        {
            List<Articulo> lista = new List<Articulo>();
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {
                string Consulta = "select codigo, Nombre, A.Descripcion, ImagenUrl,a.precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdCategoria, A.IdMarca, A.Id, A.Activo from ARTICULOS A, MARCAS M , CATEGORIAS C where  A.IdMarca = M.Id and A.IdCategoria = C.Id ";

                if (campo == "Codigo De Articulo" && criterio == "Igual a...")
                {
                    Consulta += " AND Codigo LIKE '" + filtro + "'";

                }else if (campo == "Precio" )
                {
                    switch (criterio)
                    {
                        case "Igual a...":
                            Consulta += " AND precio = '" + filtro + "'";

                            break;
                        case "Menor a...":
                            Consulta += " AND precio < " + filtro;

                            break;
                        case "Mayor a...":
                            Consulta += " AND precio > " + filtro;


                            break;
                    }                    
                }

                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Empieza con...":                            
                            Consulta += " AND Nombre LIKE '" + filtro + "%'";
                            break;
                        case "Termina con...":
                            Consulta += " AND Nombre LIKE '%" + filtro + "'";
                            break;
                        case "Contiene...":
                            Consulta += " AND Nombre LIKE '%" + filtro + "%'";
                            break;
                    }
                }

                if (estado == "Activado")
                {
                    Consulta += " and Activo = 1";
                }
                else if(estado == "Desactivado")
                {
                    Consulta += " and Activo = 0";
                }
                    




                datos.Setearconsulta(Consulta);
                datos.Ejecutarlectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.CodArt = (string)datos.Lector["Codigo"];

                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];

                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["Imagenurl"] is DBNull))
                        aux.Imagen = (string)datos.Lector["Imagenurl"];

                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = datos.Lector.GetDecimal(datos.Lector.GetOrdinal("precio"));

                    aux.Marca = new Talle();
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Cat();
                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];


                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];

                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];

                    if (!(datos.Lector["Id"] is null))
                        aux.id = (int)datos.Lector["Id"];

                    if (!(datos.Lector["Activo"] is null))
                        aux.activo = bool.Parse(datos.Lector["Activo"].ToString());

                    lista.Add(aux);

                }

                return lista;

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

        public void Modificar(Articulo nuevo)
        {
            Acceso_a_datos datos = new Acceso_a_datos();

            try
            {
                datos.Setearconsulta("update ARTICULOS set Codigo = @codigo, Nombre=@nombre, Descripcion=@descripcion, IdMarca= @IdMarca, IdCategoria=@IdCategoria, ImagenUrl=@ImagenUrl , Precio = @Precio where Id = @id");
                datos.SetearParametros("@codigo", nuevo.CodArt);
                datos.SetearParametros("@nombre", nuevo.Nombre);
                datos.SetearParametros("@descripcion", nuevo.Descripcion);
                datos.SetearParametros("@IdMarca", nuevo.Marca.Id);
                datos.SetearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.SetearParametros("@Imagenurl", nuevo.Imagen);
                datos.SetearParametros("@precio", nuevo.Precio);
                datos.SetearParametros("@Id", nuevo.id);

                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            datos.cerrarconexion();

        }

        public void Eliminar(int Id)
        {
            try
            {
                Acceso_a_datos datos = new Acceso_a_datos();

                datos.Setearconsulta("delete from	ARTICULOS where Id = @Id");
                datos.SetearParametros("@Id", Id);

                datos.ejecutaraccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void eliminarLogico(int Id)
        {
            try
            {
                Acceso_a_datos datos = new Acceso_a_datos();
                datos.Setearconsulta("update  Articulos set Activo = 0  where id = @id");
                datos.SetearParametros("@id", Id);
                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void activarLogico(int Id)
        {
            try
            {
                Acceso_a_datos datos = new Acceso_a_datos();
                datos.Setearconsulta("update  Articulos set Activo = 1  where id = @id");
                datos.SetearParametros("@id", Id);
                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
