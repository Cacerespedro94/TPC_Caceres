using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
   public class DireccionNegocio
    {
       
        public void Agregar(Direccion nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarDireccion");

                datos.agregarParametro("@Calle", nuevo.Calle);
                datos.agregarParametro("@Altura", nuevo.Altura.ToString());
                datos.agregarParametro("@CodigoPostal", nuevo.CodigoPostal);
                datos.agregarParametro("@Localidad", nuevo.Localidad);
                datos.agregarParametro("@Provincia", nuevo.Provincia);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Direccion> ListarDireccion()
        {
            List<Direccion> listadoDireccion = new List<Direccion>();
            Direccion aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarDireccion");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Direccion();

                    aux.Id = datos.lector.GetInt32(0);
                    aux.Calle = datos.lector.GetString(1);
                    aux.Altura = datos.lector.GetInt32(2);
                    aux.CodigoPostal = datos.lector.GetString(3);
                    aux.Provincia = datos.lector.GetString(4);
                    aux.Localidad = datos.lector.GetString(5);

                    listadoDireccion.Add(aux);
                }

                return listadoDireccion;
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
  
        public int BuscarIdDireccion(Direccion aux)
        {

            DireccionNegocio negocio = new DireccionNegocio();
            List<Direccion> listaDireccion = negocio.ListarDireccion();
            int IdDireccion = 0;
            foreach (var item in listaDireccion)
            {
                if (item.Calle == aux.Calle &&
                    item.Altura == aux.Altura && 
                    item.CodigoPostal == aux.CodigoPostal &&
                    item.Provincia == aux.Provincia &&
                    item.Localidad == aux.Localidad)
                {
                     IdDireccion = item.Id;
                }

            }


            return IdDireccion;
        }



    }
}

