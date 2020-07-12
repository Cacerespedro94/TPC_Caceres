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

        Usuario usuario = new Usuario();
        ClienteNegocio negocio = new ClienteNegocio();
        List<Usuario> listaCliente = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> listaCliente = new List<Usuario>();
                listaCliente = negocio.ListarClientes();

                if (!IsPostBack)
                {
                    dgvClientes.DataSource = listaCliente;
                    dgvClientes.DataBind();
                    dgvClientes.RowStyle.CssClass = "font-weight-bold";
                    if (negocio.ListarClientes().Count() >= 1)
                    {
                        dgvClientes.HeaderRow.CssClass = "bg-primary";
                    }
                }
                else
                {
                    if (txtBuscador.Text != "")
                    {
                        dgvClientes.DataSource = (List<Usuario>)Session[Session.SessionID + "filtrado"];
                        dgvClientes.DataBind();

                    }
                    else
                    {
                        dgvClientes.DataSource = negocio.ListarClientes();
                        dgvClientes.DataBind();
                    }
                }
                    if (negocio.ListarClientes().Count < 0)
                    {
                        dgvClientes.HeaderRow.CssClass = "bg-primary";

                    }
                
            }
            catch (Exception)
            {
                throw;
            }
        }
//                        if(!IsPostBack)
//                { 
//                dgvProductosAdmin.DataSource = negocio.ListarArticulos();
//                dgvProductosAdmin.DataBind();
//                dgvProductosAdmin.RowStyle.CssClass = "font-weight-bold";
//                    if (dgvProductosAdmin.DataSource != null)
//                    {
//                        dgvProductosAdmin.HeaderRow.CssClass = "bg-primary";
//                    }

//}

//                else
//                {
//                    if (txtBuscador.Text != "")
//                    {
//                        dgvProductosAdmin.DataSource = (List<Articulo>) Session[Session.SessionID + "filtrado"];
//dgvProductosAdmin.DataBind();

//                    }
//                    else
//                    {
//                        dgvProductosAdmin.DataSource = negocio.ListarArticulos();
//                        dgvProductosAdmin.DataBind();
//                    }
//                }
//                if (dgvProductosAdmin.DataSource != null)
//                {
//                    dgvProductosAdmin.HeaderRow.CssClass = "bg-primary";
//                }

        protected void dgvClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                List<Usuario> listaUsuario = new List<Usuario>();
                listaUsuario = negocio.ListarUsuario();
                int index = Convert.ToInt32(e.CommandArgument);
                int idProducto = Convert.ToInt32(dgvClientes.Rows[index].Cells[0].Text);
                negocio.eliminar(idProducto);
                Response.Redirect("ClienteVista.aspx");
            }
            if (e.CommandName == "Modificar")
            {
                List<Usuario> listaClientes = new List<Usuario>();
                listaClientes = negocio.ListarClientes();
                int index = Convert.ToInt32(e.CommandArgument);
                int idProducto = Convert.ToInt32(dgvClientes.Rows[index].Cells[0].Text);
                usuario = listaClientes.Find(J => J.Id == idProducto);

                Session.Add(Session.SessionID + "modificarCliente", usuario);

                Response.Redirect("ModificarCliente.aspx");
            }

        }

        protected void dgvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Buscador_TextChanged(object sender, EventArgs e)
        {
            List<Usuario> listaFiltrada;

            try
            {
                listaCliente = negocio.ListarClientes();
                if (txtBuscador.Text == "")
                {
                    listaFiltrada = listaCliente;
                    Session.Add(Session.SessionID + "filtrado", listaFiltrada);
                    dgvClientes.DataSource = listaFiltrada;
                    dgvClientes.DataBind();

                }
                else
                {
                    listaFiltrada = listaCliente.FindAll(k => k.Nombre.ToLower().Contains(txtBuscador.Text.ToLower()) ||

                      k.Apellido.ToLower().Contains(txtBuscador.Text.ToLower()) ||
                      k.direccion.Localidad.ToLower().Contains(txtBuscador.Text.ToLower()) ||
                      k.direccion.Provincia.ToLower().Contains(txtBuscador.Text.ToLower()) ||

                      k.Login.ToLower().Contains(txtBuscador.Text.ToLower()));
                    Session.Add(Session.SessionID + "filtrado", listaFiltrada);
                    dgvClientes.DataSource = listaFiltrada;
                    dgvClientes.DataBind();
                    if (dgvClientes.DataSource != null)
                    {
                        dgvClientes.HeaderRow.CssClass = "bg-primary";
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

