using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
   public class ClienteNegocio
    {
        public void Agregar(Cliente nuevo)
        {
            

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarCliente");

                //datos.agregarParametro("@Dni", nuevo.Dni.ToString());
                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@Apellido", nuevo.Apellido);
                datos.agregarParametro("@IngresoSesion", nuevo.User.Login);
                datos.agregarParametro("@Contraseña", nuevo.User.Password);
                datos.agregarParametro("@IdTipoUsuario", nuevo.User.tipo.ToString());
                //datos.agregarParametro("IdDireccion", nuevo.direccion.Id);
                //datos.agregarParametro("IdContacto", nuevo.contacto.Id);

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
                datos.setearSP("spEliminarCliente");
                datos.agregarParametro("@ID", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificar(Cliente nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spModificarCliente");

                datos.agregarParametro("@ID", nuevo.Id);

                datos.agregarParametro("@Dni", nuevo.Dni.ToString());
                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@Apellido", nuevo.Apellido);
                datos.agregarParametro("@IngresoSesion", nuevo.User.Login);
                datos.agregarParametro("@Contraseña", nuevo.User.Password);
                datos.agregarParametro("@IdTipoUsuario", nuevo.User.tipo.ToString());
                datos.agregarParametro("IdDireccion", nuevo.direccion.Id);
                datos.agregarParametro("IdContacto", nuevo.contacto.Id);



                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Cliente> ListarClientes()
        {
            List<Cliente> listadoClientes = new List<Cliente>();
            Cliente aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarCliente");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Cliente();

                    aux.Id = datos.lector.GetInt32(0);
                    //aux.Dni = datos.lector.GetInt64(1);
                    aux.Nombre = datos.lector.GetString(2);
                    aux.Apellido = datos.lector.GetString(3);
                    aux.User.Login = datos.lector.GetString(4);
                    aux.User.Password = datos.lector.GetString(5);
                    //aux.direccion.Calle = datos.lector.GetString(9);
                    //aux.direccion.Altura = datos.lector.GetInt32(10);
                    //aux.direccion.CodigoPostal = datos.lector.GetString(11);
                    //aux.direccion.Provincia = datos.lector.GetString(12);
                    //aux.direccion.Localidad = datos.lector.GetString(13);
                    //aux.contacto.Id = datos.lector.GetInt32(14);
                    //aux.contacto.Email = datos.lector.GetString(15);
                    //aux.contacto.Telefono = datos.lector.GetString(16);
                    aux.Estado = datos.lector.GetBoolean(17);

                    listadoClientes.Add(aux);
                }

                return listadoClientes;
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
