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
    public partial class AltaProducto : System.Web.UI.Page
    {
        Articulo nuevo = new Articulo();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            nuevo.Nombre = Nombrebox.Text;
            nuevo.Descripcion = DescBox.Text;
            nuevo.Categoria.Id = Convert.ToInt64(CategoriaBox.Text);
            nuevo.sub.Id = Convert.ToInt32(SubBox.Text);
            nuevo.Precio = Convert.ToDecimal(PrecioBox.Text);
            nuevo.ImagenUrl = ImagenBox.Text;

            negocio.Agregar(nuevo);

            
        }
    }
}