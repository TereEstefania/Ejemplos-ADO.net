using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        //propieti
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //constructor
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=DESKTOP-OJ2J6KS; database=POKEDEX_DB; integrated security=true");
            comando = new SqlCommand();
        }

        //en este metodo, le digo que el tipo de dato del comando(Consulta a la BBDD) y paso por argumento la consulta SQL
        //que se va a utilizar en la BBDD 
        public void setearConsulta(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }

        //este metodo centraliza la lectura a la base de datos
        public void ejecutarLectura()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                //executo la lectura
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
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

        public void setearParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void cerrarConexion()
        {
            if(lector != null) 
                lector.Close();
            conexion.Close();
        }


    }
}
