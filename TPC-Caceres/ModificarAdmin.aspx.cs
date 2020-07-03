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
    public partial class ModificarAdmin : System.Web.UI.Page
    {
		Articulo producto = new Articulo();
		Articulo aux = new Articulo();
		ArticuloNegocio negocio = new ArticuloNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				if (!IsPostBack)
				{
					if (Session[Session.SessionID + "modificar"] != null)
					{
						producto = (Articulo)Session[Session.SessionID + "modificar"];
						Nombrebox.Text = producto.Nombre;
						DescBox.Text = producto.Descripcion;
						CategoriaBox.Text = Convert.ToString(producto.Categoria.Id);
						Stock.Text = Convert.ToString(producto.Stock);
						PrecioBox.Text = Convert.ToString(producto.Precio);
						ImagenBox.Text = producto.ImagenUrl;
					}
				}
			}
			catch (Exception ex)
			{

				throw ex;
			}

        }


		protected void btnModificar_Click(object sender, EventArgs e)
		{   
			ArticuloNegocio neg = new ArticuloNegocio();
			producto = (Articulo)Session[Session.SessionID + "modificar"];
			producto.Nombre = Nombrebox.Text;
			producto.Descripcion = DescBox.Text;
			producto.Categoria.Id = Convert.ToInt64(CategoriaBox.Text);
			producto.Stock = Convert.ToInt32(Stock.Text);
			producto.Precio = Convert.ToDecimal(PrecioBox.Text);
			producto.ImagenUrl = ImagenBox.Text;
			neg.modificar(producto);
			Response.Redirect("ProductosAdmin.aspx");
			
		}
	}
}