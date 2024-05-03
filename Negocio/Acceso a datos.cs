using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

 namespace Negocio
{
    public class Acceso_a_datos
    {

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector; 

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public Acceso_a_datos() 
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            comando = new SqlCommand();
        } 

        public void Setearconsulta(string consulta)

        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }

        public void Ejecutarlectura() 
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarconexion()
        {
            if (lector != null)
                lector.Close();

            conexion.Close();
        }
        public void ejecutaraccion() 
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public int ejecutaraccionScalar()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                return int.Parse(comando.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void SetearParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);

        }

        public void setearProcedimiento(string sp)
        {
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;

        }
    }
}
