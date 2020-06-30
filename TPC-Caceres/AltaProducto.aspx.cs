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
        ArticuloNegocio negocio = new ArticuloNegocio();
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        Int64 IdCategoria;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            cboCategoria.DataSource = categoriaNegocio.ListarCategoria();
            cboCategoria.DataBind();
                cboCategoria.DataTextField = "Nombre";
                cboCategoria.DataValueField = "Id";
            }
         
            
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
       
             
            
            nuevo.Nombre = Nombrebox.Text;
            nuevo.Descripcion = DescBox.Text;
            nuevo.sub.Id = 1;

            nuevo.Categoria.Id = Convert.ToInt64(Session[Session.SessionID + "IdCategoria"]);
            nuevo.Precio = Convert.ToDecimal(PrecioBox.Text);
            nuevo.ImagenUrl = ImagenBox.Text;
           
            negocio.Agregar(nuevo);

            
        }

        protected void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();

            string NombreCategoria = cboCategoria.SelectedValue;
           List<Categoria> listaCategoria = categoriaNegocio.ListarCategoria();

            cat = listaCategoria.Find(J => J.Nombre == NombreCategoria);
            IdCategoria = cat.Id;
            Session.Add(Session.SessionID + "IdCategoria", IdCategoria);

        }
    }
}