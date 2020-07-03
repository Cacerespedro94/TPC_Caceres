using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TPC_Caceres
{
    public partial class ProductosAdmin : System.Web.UI.Page
    {
        Articulo producto = new Articulo();
        ArticuloNegocio negocio = new ArticuloNegocio();
        public List<Articulo> listaProductos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Articulo producto = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaProductos = negocio.ListarArticulos();
            try
			{
                if(!IsPostBack)
                { 
                dgvProductosAdmin.DataSource = negocio.ListarArticulos();
                dgvProductosAdmin.DataBind();
                dgvProductosAdmin.RowStyle.CssClass = "font-weight-bold";
                    if (dgvProductosAdmin.DataSource != null)
                    {
                        dgvProductosAdmin.HeaderRow.CssClass = "bg-primary";
                    }

                }

                else
                {
                    if (txtBuscador.Text != "")
                    {
                        dgvProductosAdmin.DataSource = (List<Articulo>)Session[Session.SessionID + "filtrado"];
                        dgvProductosAdmin.DataBind();

                    }
                    else
                    {
                        dgvProductosAdmin.DataSource = negocio.ListarArticulos();
                        dgvProductosAdmin.DataBind();
                    }
                }
                if (dgvProductosAdmin.DataSource != null)
                {
                    dgvProductosAdmin.HeaderRow.CssClass = "bg-primary";
                }
            }

			catch (Exception ex)
			{

				throw ex;
			}
        }

        protected void dgvProductosAdmin_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                List<Articulo> ListaProductos = new List<Articulo>();
                ListaProductos = negocio.ListarArticulos();
                int index = Convert.ToInt32(e.CommandArgument);
                int idProducto = Convert.ToInt32(dgvProductosAdmin.Rows[index].Cells[0].Text);
                negocio.eliminar(idProducto);
                Response.Redirect("ProductosAdmin.aspx");
            }
            if (e.CommandName == "Modificar")
            {
                List<Articulo> ListaProductos = new List<Articulo>();
                ListaProductos = negocio.ListarArticulos();
                int index = Convert.ToInt32(e.CommandArgument);
                int idProducto = Convert.ToInt32(dgvProductosAdmin.Rows[index].Cells[0].Text);
                producto = ListaProductos.Find(J => J.Id == idProducto);
              
                Session.Add(Session.SessionID + "modificar", producto);
                
                Response.Redirect("ModificarAdmin.aspx");
            }

        }
        protected void Buscador_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
        
            try
            {
                listaProductos = negocio.ListarArticulos();
                if (txtBuscador.Text == "")
                {
                    listaFiltrada = listaProductos;
                    Session.Add(Session.SessionID + "filtrado", listaFiltrada);
                    dgvProductosAdmin.DataSource = listaFiltrada;
                    dgvProductosAdmin.DataBind();

                }
                else
                {
                    listaFiltrada = listaProductos.FindAll(k => k.Nombre.ToLower().Contains(txtBuscador.Text.ToLower()) ||

                      k.Categoria.Nombre.ToLower().Contains(txtBuscador.Text.ToLower()) ||
                      k.Nombre.ToLower().Contains(txtBuscador.Text.ToLower()));
                    Session.Add(Session.SessionID + "filtrado", listaFiltrada);
                    dgvProductosAdmin.DataSource = listaFiltrada;
                    dgvProductosAdmin.DataBind();
                    if (dgvProductosAdmin.DataSource != null)
                    {
                        dgvProductosAdmin.HeaderRow.CssClass = "bg-primary";
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
            protected void dgvProductosAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}