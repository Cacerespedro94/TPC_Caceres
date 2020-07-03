using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Microsoft.SqlServer.Server;

namespace Negocio
{
  public  class VentaNegocio
    {
        public void AgregarVenta(Venta nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarVenta");

               
                datos.agregarParametro("@Cantidad", nuevo.carro.Cantidad);
                datos.agregarParametro("@Total", nuevo.carro.SubTotal);
                datos.agregarParametro("@Fecha", nuevo.fecha);
                datos.agregarParametro("@IdCliente", nuevo.cliente.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Venta> ListarVentas()
        {
            List<Venta> listadoVenta = new List<Venta>();
            Venta aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarVentas");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Venta();

                    aux.Id = datos.lector.GetInt32(0);
                    aux.cliente.Id = datos.lector.GetInt32(1); 
                    aux.producto.CantidadUnidades = datos.lector.GetInt32(2);
                    aux.carro.SubTotal = Decimal.Round(datos.lector.GetDecimal(3),2);
                    aux.fecha = datos.lector.GetDateTime(4);
                 

                    

                    listadoVenta.Add(aux);
                }

                return listadoVenta;
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
        public List<Venta> ListarVentasCliente(int IdVenta)
        {
            List<Venta> listadoVenta = new List<Venta>();
            Venta aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarVentasCliente");
                //datos.agregarParametro("@IdCliente", IdCliente);
                datos.agregarParametro("@IdVenta", IdVenta);
                datos.ejecutarAccion();
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Venta();

                    aux.producto.Nombre = datos.lector.GetString(0);
                    aux.producto.Precio = Decimal.Round(datos.lector.GetDecimal(1),2);
                    aux.fecha = datos.lector.GetDateTime(2);
                    aux.Id = datos.lector.GetInt32(3);
                    aux.producto.CantidadUnidades = datos.lector.GetInt32(4);
                    aux.producto.ImagenUrl = datos.lector.GetString(5);


                    listadoVenta.Add(aux);
                }

                return listadoVenta;
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


        public List<Venta> ListarCompras(Usuario usuario)
        {
            List<Venta> listadoVenta = new List<Venta>();
            Venta aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarCompras");
                datos.agregarParametro("@IdCliente", usuario.Id);
                datos.ejecutarAccion();
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Venta();
                    aux.Id = datos.lector.GetInt32(0);
                    aux.carro.SubTotal = Decimal.Round(datos.lector.GetDecimal(1),2);
                    aux.fecha = datos.lector.GetDateTime(2);
                    aux.carro.Cantidad = datos.lector.GetInt32(3);

                    listadoVenta.Add(aux);
                }

                return listadoVenta;
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

        public List<Venta> ListarVentasAdministrador()
        {
            List<Venta> listadoVenta = new List<Venta>();
            Venta aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarVentasAdministrador");

                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Venta();
                    aux.Id = datos.lector.GetInt32(0);
                    aux.cliente.Apellido = datos.lector.GetString(1);
                    aux.cliente.Nombre = datos.lector.GetString(2);
                    aux.carro.SubTotal = Decimal.Round(datos.lector.GetDecimal(3),2);
                    aux.carro.Cantidad = datos.lector.GetInt32(4);
                    aux.fecha = datos.lector.GetDateTime(5);

                    listadoVenta.Add(aux);
                }

                return listadoVenta;
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

        public void AgregarProductos_Por_Ventas(Venta nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregarProductos_Por_Ventas");

                datos.agregarParametro("@IdProducto", nuevo.producto.Id);
                datos.agregarParametro("@IdVenta", nuevo.Id);
                datos.agregarParametro("@CantidadUnidades", nuevo.producto.CantidadUnidades);
                datos.agregarParametro("@Precio", nuevo.producto.Precio);


                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Ventas_x_Usuario(Venta nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spVentas_x_Usuario");

                datos.agregarParametro("@IdCliente", nuevo.cliente.Id);
                datos.agregarParametro("@IdVenta", nuevo.Id);


                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

  


    }
}
