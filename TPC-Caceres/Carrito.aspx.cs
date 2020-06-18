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
        public Carro prue = new Carro();
        List<Articulo> listaArticulo;
        Articulo ar = new Articulo();
        ArticuloNegocio negocio = new ArticuloNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session[Session.SessionID + "elemento"] != null)
                {
                    prue = (Carro)Session[Session.SessionID + "elemento"];
                    dgvCarrito.DataSource = prue.Item;
                    dgvCarrito.DataBind();
                    dgvCarrito.RowStyle.CssClass = "font-weight-bold";
                    
                    Total.Text = "$" + prue.SubTotal.ToString();
                    if (prue.Cantidad == 1)
                    {
                        CanUni.Text = "Estás llevando " + prue.Cantidad + " unidad...";
                    }
                    else
                    {
                        CanUni.Text = "Estás llevando " + prue.Cantidad + " unidades...";
                    }
                    if (prue.Cantidad > 0)
                    {
                        dgvCarrito.HeaderRow.CssClass = "bg-primary";
                    }
                }

                //listaProductos = negocio.ListarArticulos();

                //listaArticulo = negocio.ListarArticulos();

                //dgvCarrito.DataSource = listaProductos;
                //dgvCarrito.DataBind();
                //dgvCarrito.RowStyle.CssClass = "font-weight-bold";
                //dgvCarrito.HeaderStyle.CssClass = "bg-primary";

            }


            catch (Exception)
            {

                throw;
            }

        }
    }
}