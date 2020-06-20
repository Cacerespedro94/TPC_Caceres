using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dominio;

namespace Negocio
{
    class SubCategoriaNegocio
    {

        public void Agregar(SubCategoria nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarSubCategoria");

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
                datos.setearSP("spEliminarSubCategoria");
                datos.agregarParametro("@ID", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Modificar(SubCategoria nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spModificarSubCategoria");

                datos.agregarParametro("@ID", nuevo.Id);
                datos.agregarParametro("@Nombre", nuevo.Nombre);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<SubCategoria> ListarSubCategoria()
        {
            List<SubCategoria> listadoSubCategoria = new List<SubCategoria>();
            SubCategoria aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarSubCategoria");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new SubCategoria();

                    aux.Id = datos.lector.GetInt32(0);
                    aux.Nombre = datos.lector.GetString(1);

                    aux.Eliminado = datos.lector.GetBoolean(3);

                    listadoSubCategoria.Add(aux);
                }

                return listadoSubCategoria;
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
