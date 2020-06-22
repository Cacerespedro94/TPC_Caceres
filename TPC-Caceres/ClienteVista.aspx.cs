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
    public partial class ClienteVista : System.Web.UI.Page
    {

        Cliente cliente = new Cliente();
        ClienteNegocio negocio = new ClienteNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               
                dgvClientes.DataSource = negocio.ListarClientes();
                dgvClientes.DataBind();
                dgvClientes.RowStyle.CssClass = "font-weight-bold";
                if (dgvClientes.DataSource != null)
                {
                    dgvClientes.HeaderRow.CssClass = "bg-primary";
                }
            }

            catch (Exception)
            {
                throw;
            }
        }


        protected void dgvClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                List<Cliente> listaClientes = new List<Cliente>();
                listaClientes = negocio.ListarClientes();
                int index = Convert.ToInt32(e.CommandArgument);
                int idProducto = Convert.ToInt32(dgvClientes.Rows[index].Cells[0].Text);
                negocio.eliminar(idProducto);
                Response.Redirect("ClienteVista.aspx");
            }
            if (e.CommandName == "Modificar")
            {
                List<Cliente> listaClientes = new List<Cliente>();
                listaClientes = negocio.ListarClientes();
                int index = Convert.ToInt32(e.CommandArgument);
                int idProducto = Convert.ToInt32(dgvClientes.Rows[index].Cells[0].Text);
                cliente = listaClientes.Find(J => J.Id == idProducto);

                Session.Add(Session.SessionID + "modificarCliente", cliente);

                Response.Redirect("ModificarCliente.aspx");
            }

        }

        protected void dgvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}