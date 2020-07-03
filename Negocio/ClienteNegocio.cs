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
        public void Agregar(Usuario nuevo)
        {
            

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarCliente");

                datos.agregarParametro("@Dni", nuevo.dni);
                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@Apellido", nuevo.Apellido);
                datos.agregarParametro("@IngresoSesion", nuevo.Login);
                datos.agregarParametro("@Contraseña", nuevo.Password);
                datos.agregarParametro("@IdTipoUsuario", nuevo.TipoUsuario.ToString());
                //datos.agregarParametro("IdDireccion", nuevo.direccion.Id);
                //datos.agregarParametro("IdContacto", nuevo.contacto.Id);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void AgregarDatosCliente(Usuario nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarDatosCliente");

                datos.agregarParametro("@IdUsuario", nuevo.Id);

                datos.agregarParametro("@IdContacto", nuevo.contacto.Id);

                datos.agregarParametro("@IdDireccion", nuevo.direccion.Id);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void ModificarDatosCliente(Usuario nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spModificarDatosCliente");

                datos.agregarParametro("@IdUsuario", nuevo.Id);

                datos.agregarParametro("@IdContacto", nuevo.contacto.Id);

                datos.agregarParametro("@IdDireccion", nuevo.direccion.Id);

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

        public void modificar(Usuario nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spModificarCliente");

                datos.agregarParametro("@ID", nuevo.Id);

                //datos.agregarParametro("@Dni", nuevo.dni));
                //datos.agregarParametro("@Nombre", nuevo.Nombre);
                //datos.agregarParametro("@Apellido", nuevo.Apellido);
                //datos.agregarParametro("@IngresoSesion", nuevo.);
                //datos.agregarParametro("@Contraseña", nuevo.User.Password);
                //datos.agregarParametro("@IdTipoUsuario", nuevo.User.tipo.ToString());
                datos.agregarParametro("IdDireccion", nuevo.direccion.Id);
                datos.agregarParametro("IdContacto", nuevo.contacto.Id);



                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Usuario> ListarClientes()
        {
            List<Usuario> listadoClientes = new List<Usuario>();
            Usuario aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarCliente");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Usuario();

                    aux.Id = datos.lector.GetInt32(0);
            
                    aux.dni = datos.lector.GetString(1);
                    aux.Nombre = datos.lector.GetString(2);
                    aux.Apellido = datos.lector.GetString(3);
                    aux.TipoUsuario = datos.lector.GetInt32(4);
                    aux.TipoUsuarioNombre = datos.lector.GetString(5);
                    aux.Login = datos.lector.GetString(6);
                    aux.Password = datos.lector.GetString(7);
                    aux.direccion.Id = datos.lector.GetInt32(8);
                    aux.direccion.Calle = datos.lector.GetString(9);
                    aux.direccion.Altura = datos.lector.GetInt32(10);
                    aux.direccion.CodigoPostal = datos.lector.GetString(11);
                    aux.direccion.Provincia = datos.lector.GetString(12);
                    aux.direccion.Localidad = datos.lector.GetString(13);
                    aux.contacto.Id = datos.lector.GetInt32(14);
                    aux.contacto.Email = datos.lector.GetString(15);
                    aux.contacto.Telefono = datos.lector.GetString(16);
                    aux.Eliminado = datos.lector.GetBoolean(17);


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

        public List<Usuario> ListarUsuario()
        {
            List<Usuario> listadoClientes = new List<Usuario>();
            Usuario aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarUsuario");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Usuario();

                    aux.Id = datos.lector.GetInt32(0);

                    //aux.dni = datos.lector.GetString(1);
                    aux.Nombre = datos.lector.GetString(1);
                    aux.Apellido = datos.lector.GetString(2);
                    aux.TipoUsuario = datos.lector.GetInt32(3);
                    aux.TipoUsuarioNombre = datos.lector.GetString(4);
                    aux.Login = datos.lector.GetString(5);
                    aux.Password = datos.lector.GetString(6);
                    //aux.direccion.Id = datos.lector.GetInt32(8);
                    //aux.direccion.Calle = datos.lector.GetString(9);
                    //aux.direccion.Altura = datos.lector.GetInt32(10);
                    //aux.direccion.CodigoPostal = datos.lector.GetString(11);
                    //aux.direccion.Provincia = datos.lector.GetString(12);
                    //aux.direccion.Localidad = datos.lector.GetString(13);
                    //aux.contacto.Id = datos.lector.GetInt32(14);
                    //aux.contacto.Email = datos.lector.GetString(15);
                    //aux.contacto.Telefono = datos.lector.GetString(16);
                    aux.Eliminado = datos.lector.GetBoolean(7);


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
