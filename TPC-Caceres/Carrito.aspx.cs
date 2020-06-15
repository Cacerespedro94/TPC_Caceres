using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Caceres
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<Articulo> listaProductos { get; set; }
        public Dominio.Carrito prue = new Dominio.Carrito();
        List<Articulo> listaArticulo;
        Articulo ar = new Articulo();
        ArticuloNegocio negocio = new ArticuloNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

                listaProductos = negocio.ListarArticulos();

                listaArticulo = negocio.ListarArticulos();

                dgvPrueba.DataSource = listaProductos;
                dgvPrueba.DataBind();
                dgvPrueba.RowStyle.CssClass = "font-weight-bold";


            }

            catch (Exception)
            {
                throw;
            }

        }
    }
}