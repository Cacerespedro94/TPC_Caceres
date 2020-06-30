using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
namespace Negocio

{
    public class CategoriaNegocio
    {
        public void Agregar(Categoria nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarCategoria");

                datos.agregarParametro("@Nombre", nuevo.Nombre);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spEliminarCategoria");
                datos.agregarParametro("@ID", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Modificar(Categoria nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spModificarCategoria");

                datos.agregarParametro("@ID", nuevo.Id);
                datos.agregarParametro("@Nombre", nuevo.Nombre);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Categoria> ListarCategoria()
        {
            List<Categoria> listadoCategoria = new List<Categoria>();
            Categoria aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarCategoria");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Categoria();

                    aux.Id = datos.lector.GetInt64(0);
                    aux.Nombre = datos.lector.GetString(1);
                 
                    aux.Eliminado = datos.lector.GetBoolean(2);

                    listadoCategoria.Add(aux);
                }

                return listadoCategoria;
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
