using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//System.Data.SqlClient es una libreria que necesito para la conexion a base de datos
using dominio;


namespace negocio
{
    public class PokemonService
    {
        //aca deben esatr los metodos para el acceso a mi BBDD
        public List<Pokemon> ListarEJEMPLO()
        {
            List<Pokemon> lista = new List<Pokemon>();
            //necesito conectarme con una base de datos lo hago con la siguiente clase
            SqlConnection conexion = new SqlConnection();
            //para realizar acciones necesito
            SqlCommand comando = new SqlCommand();
            //una vez que tenga los set datos nesecito leerlos y lo voy a alojar, cuando me llega este set se convierte en un objeto de tipo
            //DataReader el cual 
            SqlDataReader lector;

            try
            {
                //primero las configuaraciones
                //la conexion a la bbdd local
                // 1- a que servidor me voy a conectar
                // 2- a que base de datos voy aconectarme
                //3 - la conexion de seguridad, como me estoy conectando por medio de window autentication es asi, pero si fuera por una IP
                // tendria que ponerlo en False; user...; password...;
                conexion.ConnectionString = "server=DESKTOP-OJ2J6KS; database=POKEDEX_DB; integrated security=true";
                //segunda configuracion
                //el tipo en la que voy a hacer el comando
                comando.CommandType = System.Data.CommandType.Text;
                //luego debo escribir la consulta a la bbdd
                //por errores es conveniente hacerlo primero en la bbdd, la pruebo y si  esta bien la copio aca
                comando.CommandText = "select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad From POKEMONS P, ELEMENTOS E, ELEMENTOS D\r\nwhere E.id = P.IdTipo and D.Id = P.IdDebilidad;";
                //comando la conexion
                comando.Connection = conexion;
                //abro la conexion
                conexion.Open();
                //executo la lectura
                lector = comando.ExecuteReader();

                //si lector tiene algo para leer es true y entra, al hacer esto lector es como que se pone en un puntero en la primer fila de la tabla
                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);// esta e una de las formas de trae el dato, colocando el tipo de dato de la primera columna y su indice
                    aux.Nombre = (string)lector["Nombre"];//esta es la otra forma, le pasamos el nombre de columna y lo parseamo a el tipo que es la columna
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux);//aca devuelve una lista de objetos, se le va agregando a lisa<> cada objeto aux que va iterando

                }

                return lista;


            }
            catch (Exception ex)// aca hubo un error porque me atrapo que escribi mal una de las propiedades para la conexion, coloque serve en vez de server
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }

        public List<Pokemon> Listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad From POKEMONS P, ELEMENTOS E, ELEMENTOS D\r\nwhere E.id = P.IdTipo and D.Id = P.IdDebilidad;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];

                    lista.Add(aux);

                }

                return lista;

            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public void Agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into POKEMONS(Numero,Nombre,Descripcion,Activo,IdTipo,IdDebilidad)values(" + nuevo.Numero + ",'" + nuevo.Nombre + "','" + nuevo.Descripcion + "',1, @idTipo, @idDebilidad)");
                datos.setearParametros("@idTipo", nuevo.Tipo.Id);
                datos.setearParametros("@idDebilidad", nuevo.Debilidad.Id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
