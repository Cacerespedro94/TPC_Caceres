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
        //public List<Articulo> ListarArticulos()
        //{
        //    List<Articulo> listadoArticulo = new List<Articulo>();
        //    Articulo aux;
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setearSP("spListarProductos");
        //        datos.ejecutarLector();
        //        while (datos.lector.Read())
        //        {
        //            aux = new Articulo();

        //            aux.Id = datos.lector.GetInt32(0);
        //            aux.Nombre = datos.lector.GetString(1);
        //            aux.Descripcion = datos.lector.GetString(2);
        //            aux.Categoria = new Categoria();
        //            aux.Categoria.Nombre = (string)datos.lector["DescCat"];
        //            aux.Categoria.Id = datos.lector.GetInt64(4);
        //            aux.sub = new SubCategoria();
        //            aux.sub.Nombre = (string)datos.lector["NombreCat"];
        //            aux.sub.Id = datos.lector.GetInt32(6);
        //            aux.ImagenUrl = datos.lector.GetString(7);
        //            aux.Precio = Decimal.Round((decimal)datos.lector["Precio"], 2);
        //            aux.Eliminado = datos.lector.GetBoolean(9);

        //            listadoArticulo.Add(aux);
        //        }

        //        return listadoArticulo;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}
        }
    }
