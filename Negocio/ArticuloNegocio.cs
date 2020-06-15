using System;
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
         

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                    conexion.ConnectionString = "data source= DESKTOP-PJFNJ5R\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "insert into ARTICULOS (Nombre, Codigo, Descripcion, IdCategoria, IdMarca, ImagenUrl, Precio) Values (@Nombre,@Codigo,@Descripcion,@IdCategoria,@IdMarca,@ImagenUrl,@Precio)";
                    comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                    
                    comando.Parameters.AddWithValue("@Descripcion", nuevo.Descripcion);
                    comando.Parameters.AddWithValue("@IdCategoria", nuevo.Categoria.Id.ToString());
                    comando.Parameters.AddWithValue("@Precio", nuevo.Precio);
                    comando.Parameters.AddWithValue("@ImagenUrl", nuevo.ImagenUrl);

                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from Articulos where id =" + id);
                datos.ejecutarAccion();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("Update ARTICULOS set Codigo=@Codigo,Nombre=@Nombre, Descripcion=@Descripcion, ImagenURL=@ImagenURL, Precio=@Precio, IdMarca=@IdMarca, IdCategoria = @IdCategoria where Id=@Id");
                
                datos.agregarParametro("@Nombre", articulo.Nombre);
                datos.agregarParametro("@Id", articulo.Id);
                datos.agregarParametro("IdCategoria", articulo.Categoria.Id);
                datos.agregarParametro("@Descripcion", articulo.Descripcion);
                datos.agregarParametro("@ImagenURL", articulo.ImagenUrl);
                datos.agregarParametro("@Precio", articulo.Precio);
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
                datos.setearQuery("select a.id, a.Nombre, a.Descripcion, C.Nombre as DescCat, C.Id as IdCat, S.Nombre as NombreCat,S.Id as IdSub, a.ImagenUrl, a.Precio from Producto as A inner join Categoria as C on C.Id = a.IdCategoria inner join SubCategoria as S on S.Id = a.IdSubCategoria");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Articulo();
                    
                    aux.Id = datos.lector.GetInt64(0);
                    aux.Nombre = datos.lector.GetString(1);
                    aux.Descripcion = datos.lector.GetString(2);
                    aux.Categoria = new Categoria();
                    aux.Categoria.Nombre = (string)datos.lector["DescCat"];
                    aux.Categoria.Id = datos.lector.GetInt64(4);
                    aux.sub = new SubCategoria();
                    aux.sub.Nombre = (string)datos.lector["NombreCat"];
                    aux.sub.Id = datos.lector.GetInt32(6);
                    aux.ImagenUrl = datos.lector.GetString(7);
                    aux.Precio = Decimal.Round((decimal)datos.lector["Precio"], 2);
                    
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
