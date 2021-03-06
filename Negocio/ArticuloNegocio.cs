﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class ArticuloNegocio
    {
        public void Agregar(Articulo nuevo)
        {


            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spAgregar");

                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@Descripcion", nuevo.Descripcion);
                datos.agregarParametro("@IdCategoria", nuevo.Categoria.Id.ToString());
                datos.agregarParametro("@Precio", nuevo.Precio);
                datos.agregarParametro("@ImagenUrl", nuevo.ImagenUrl);

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
                datos.setearSP("spEliminar");
                datos.agregarParametro("@ID", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificar(Articulo nuevo)
        {
           
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spModificar");

                datos.agregarParametro("@ID", nuevo.Id);
                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.agregarParametro("@Descripcion", nuevo.Descripcion);
                datos.agregarParametro("@Stock", nuevo.Stock);
                datos.agregarParametro("@Precio", nuevo.Precio);
                datos.agregarParametro("@ImagenUrl", nuevo.ImagenUrl);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarStockProducto(Articulo nuevo)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spModificarStockProducto");

                datos.agregarParametro("@ID", nuevo.Id);
                datos.agregarParametro("@Stock", nuevo.Stock);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> listadoArticulo = new List<Articulo>();
            Articulo aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("spListarProductos");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Articulo();

                    aux.Id = datos.lector.GetInt32(0);
                    aux.Nombre = datos.lector.GetString(1);
                    aux.Descripcion = datos.lector.GetString(2);
                    aux.Categoria = new Categoria();
                    aux.Categoria.Nombre = (string)datos.lector["DescCat"];
                    aux.Categoria.Id = datos.lector.GetInt64(4);
                    aux.ImagenUrl = datos.lector.GetString(5);
                    aux.Precio = Decimal.Round((decimal)datos.lector["Precio"], 2);
                    aux.Eliminado = datos.lector.GetBoolean(7);
                    aux.Stock = datos.lector.GetInt32(8);

                    listadoArticulo.Add(aux);
                }

                return listadoArticulo;
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

        public List<Articulo> ListarArticulosMasVendidos()
        {
            List<Articulo> listadoArticulo = new List<Articulo>();
            Articulo aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select * from vwListarRankingProductos");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Articulo();

                    aux.Id = datos.lector.GetInt32(0);
                    aux.Nombre = datos.lector.GetString(1);
                    aux.Precio = datos.lector.GetDecimal(2);
                    aux.Descripcion = datos.lector.GetString(3);
                    aux.CantidadUnidades = datos.lector.GetInt32(4);


                    listadoArticulo.Add(aux);
                }

                return listadoArticulo;
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
