using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
  public class AdministradorNegocio
    {
        public void Agregar(Administrador nuevo)
        {
           

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarAdministrador");

                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@Apellido", nuevo.Apellido);
                datos.agregarParametro("@Dni", nuevo.Dni.ToString());
                datos.agregarParametro("@Login", nuevo.User.Login);
                datos.agregarParametro("@Password", nuevo.User.Password);
      
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void eliminarAdministrador(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spEliminarAdministrador");
                datos.agregarParametro("@ID", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificar(Administrador nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spModificarAdministrador");

                datos.agregarParametro("@ID", nuevo.Id);
                

                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@Apellido", nuevo.Apellido);
                datos.agregarParametro("@Dni", nuevo.Dni.ToString());
                datos.agregarParametro("@Login", nuevo.User.Login);
                datos.agregarParametro("@Password", nuevo.User.Password);

                datos.ejecutarAccion();

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Administrador> ListarAdministrador()
        {
            List<Administrador> listadoAdministrador = new List<Administrador>();
            Administrador aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarAdministrador");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Administrador();
                  
                    aux.Id = datos.lector.GetInt32(0);
                    aux.Nombre = datos.lector.GetString(1);
                    aux.Apellido = datos.lector.GetString(2);
                    aux.User.Login = datos.lector.GetString(3);
                    aux.User.Password = datos.lector.GetString(4);
                    aux.User.tipo = datos.lector.GetInt32(5);
               

                    listadoAdministrador.Add(aux);
                }

                return listadoAdministrador;
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
