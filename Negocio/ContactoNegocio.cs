using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
   public class ContactoNegocio
    {
        public void Agregar(Contacto nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarContacto");

                datos.agregarParametro("@Email", nuevo.Email);
                datos.agregarParametro("@Telefono", nuevo.Telefono);


                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Contacto> ListarContacto()
        {
            List<Contacto> listadoContacto = new List<Contacto>();
            Contacto aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarContacto");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Contacto();
                    aux.Id = datos.lector.GetInt32(0);
                    aux.Email = datos.lector.GetString(1);
                    aux.Telefono = datos.lector.GetString(2);

                    listadoContacto.Add(aux);
                }

                return listadoContacto;
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
        public int BuscarIdContacto(Contacto aux)
        {
            ContactoNegocio negocio = new ContactoNegocio();
            List<Contacto> listaContacto = negocio.ListarContacto();
            int IdContacto = 0;
            foreach (var item in listaContacto)
            {
                if (item.Telefono == aux.Telefono && item.Email == aux.Email)
                {
                    IdContacto = item.Id;
                }

            }

            return IdContacto;


        }

        public bool SiExisteContacto(Contacto aux)
        {
            ContactoNegocio negocio = new ContactoNegocio();
            List<Contacto> listaContacto = negocio.ListarContacto();
            
            foreach (var item in listaContacto)
            {
                if (item.Telefono == aux.Telefono && item.Email == aux.Email)
                {
                    return true;
                }

            }

            return false;


        }

    }
}
