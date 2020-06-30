using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
  public class ProveedorNegocio
    {
        public void Agregar(Proveedor nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarProveedor");
                datos.agregarParametro("Nombre", nuevo.Nombre);
                datos.agregarParametro("IdDireccion", nuevo.direccion.Id);
                datos.agregarParametro("IdContacto", nuevo.contacto.Id);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spEliminarProveedor");
                datos.agregarParametro("@ID", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificar(Proveedor nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spModificarProveedor");

                datos.agregarParametro("@ID", nuevo.Id);
                datos.agregarParametro("Nombre", nuevo.Nombre);
                datos.agregarParametro("IdDireccion", nuevo.direccion.Id);
                datos.agregarParametro("IdContacto", nuevo.contacto.Id);



                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Proveedor> ListarProveedor()
        {
            List<Proveedor> listadoProveedor = new List<Proveedor>();
            Proveedor aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarProveedor");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Proveedor();

                    aux.Id = datos.lector.GetInt32(0);
                    aux.Nombre = datos.lector.GetString(1);
                    aux.direccion.Id = datos.lector.GetInt32(2);
                    aux.direccion.Calle = datos.lector.GetString(3);
                    aux.direccion.Altura = datos.lector.GetInt32(4);
                    aux.direccion.CodigoPostal = datos.lector.GetString(5);
                    aux.direccion.Localidad = datos.lector.GetString(6);
                    aux.direccion.Provincia = datos.lector.GetString(7);
                    aux.contacto.Id = datos.lector.GetInt32(8);
                    aux.contacto.Email = datos.lector.GetString(9);
                    aux.contacto.Telefono = datos.lector.GetString(10);
                    aux.Eliminado = datos.lector.GetBoolean(11);
                  

                    listadoProveedor.Add(aux);
                }

                return listadoProveedor;
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
