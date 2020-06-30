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
    public partial class ProveedorAdmin : System.Web.UI.Page
    {
        Proveedor proveedor = new Proveedor();
        ProveedorNegocio negocio = new ProveedorNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {

                dgvProveedores.DataSource = negocio.ListarProveedor();
                dgvProveedores.DataBind();
                dgvProveedores.RowStyle.CssClass = "font-weight-bold";
                if (negocio.ListarProveedor().Count() >= 1)
                {
                    dgvProveedores.HeaderRow.CssClass = "bg-primary";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void dgvProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dgvProveedores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                List<Proveedor> ListaProveedor = new List<Proveedor>();
                ListaProveedor = negocio.ListarProveedor();
                int index = Convert.ToInt32(e.CommandArgument);
                int idProveedor = Convert.ToInt32(dgvProveedores.Rows[index].Cells[0].Text);
                negocio.eliminar(idProveedor);
                Response.Redirect("ProveedorAdmin.aspx");
            }
            if (e.CommandName == "Modificar")
            {
                List<Proveedor> ListaProveedor = new List<Proveedor>();
                ListaProveedor = negocio.ListarProveedor();
                int index = Convert.ToInt32(e.CommandArgument);
                int idproveedor= Convert.ToInt32(dgvProveedores.Rows[index].Cells[0].Text);
                proveedor = ListaProveedor.Find(J => J.Id == idproveedor);
                proveedor.Id = idproveedor;
                Session.Add(Session.SessionID + "modificar", proveedor);

                Response.Redirect("ModificarProveedor.aspx");
            }

        }
    }
}