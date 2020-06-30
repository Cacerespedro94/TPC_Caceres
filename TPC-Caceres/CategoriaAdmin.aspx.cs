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
    public partial class CategoriaAdmin : System.Web.UI.Page
    {
        Categoria categoria = new Categoria();
        CategoriaNegocio negocio = new CategoriaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {

                dgvCategorias.DataSource = negocio.ListarCategoria();
                dgvCategorias.DataBind();
                dgvCategorias.RowStyle.CssClass = "font-weight-bold";
                if (dgvCategorias.DataSource != null)
                {
                    dgvCategorias.HeaderRow.CssClass = "bg-primary";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();
                    
            categoria.Nombre = CategoriaBox.Text;
            negocio.Agregar(categoria);
            Response.Redirect("CategoriaAdmin.aspx");
        }

        protected void dgvCategorias_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                List<Categoria> listaCategorias = new List<Categoria>();
                listaCategorias = negocio.ListarCategoria();
                int index = Convert.ToInt32(e.CommandArgument);
                int idCategoria = Convert.ToInt32(dgvCategorias.Rows[index].Cells[0].Text);
                negocio.Eliminar(idCategoria);
                Response.Redirect("CategoriaAdmin.aspx");
            }
            //if (e.CommandName == "Modificar")
            //{
            //    List<Cliente> listaClientes = new List<Cliente>();
            //    listaClientes = negocio.ListarClientes();
            //    int index = Convert.ToInt32(e.CommandArgument);
            //    int idProducto = Convert.ToInt32(dgvClientes.Rows[index].Cells[0].Text);
            //    cliente = listaClientes.Find(J => J.Id == idProducto);

            //    Session.Add(Session.SessionID + "modificarCliente", cliente);

            //    Response.Redirect("ModificarCliente.aspx");
            //}
        }

        protected void dgvCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}