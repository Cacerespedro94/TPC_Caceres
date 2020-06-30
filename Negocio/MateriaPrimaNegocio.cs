using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class MateriaPrimaNegocio
    {
        public void Agregar(MateriaPrima nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarMaterial");
                datos.agregarParametro("Nombre", nuevo.Nombre);
                datos.agregarParametro("Descripcion", nuevo.Descripcion);
                datos.agregarParametro("IdProveedor", nuevo.proveedor.Id);
                datos.agregarParametro("Stock", nuevo.Stock);
                

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
                datos.setearSP("spEliminarMaterial");
                datos.agregarParametro("@ID", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Modificar(MateriaPrima nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spModificarCliente");

                datos.agregarParametro("@ID", nuevo.Id);
                datos.agregarParametro("Nombre", nuevo.Nombre);
                datos.agregarParametro("Descripcion", nuevo.Descripcion);
                datos.agregarParametro("IdProveedor", nuevo.proveedor.Id);
                datos.agregarParametro("Stock", nuevo.Stock);



                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<MateriaPrima> ListarMaterial()
        {
            List<MateriaPrima> listadoMaterial = new List<MateriaPrima>();
            MateriaPrima aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarMaterial");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new MateriaPrima();
                   
                    aux.Id = datos.lector.GetInt32(0);
                    aux.Nombre = datos.lector.GetString(1);
                    aux.Descripcion = datos.lector.GetString(2);
                    aux.Stock = datos.lector.GetDouble(3);
                    aux.proveedor.Id = datos.lector.GetInt32(4);
                    aux.proveedor.Nombre = datos.lector.GetString(5);
                    aux.Eliminado = datos.lector.GetBoolean(6);

                    listadoMaterial.Add(aux);
                }

                return listadoMaterial;
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
