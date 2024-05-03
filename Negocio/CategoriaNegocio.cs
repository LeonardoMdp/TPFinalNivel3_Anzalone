using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
           public  List<Cat> ListadodeCategorias()
               
        {
            List<Cat> Lista = new List<Cat>();
            Acceso_a_datos datos = new Acceso_a_datos();

            try
            {
                datos.Setearconsulta("select Id, Descripcion from CATEGORIAS");
                datos.Ejecutarlectura();


                while(datos.Lector.Read())
                {

                    Cat aux = new Cat();
                    aux.Descripcion = (String)datos.Lector["descripcion"];
                    aux.Id = (int)datos.Lector["id"];

                    Lista.Add(aux);
                }
            return Lista;


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
