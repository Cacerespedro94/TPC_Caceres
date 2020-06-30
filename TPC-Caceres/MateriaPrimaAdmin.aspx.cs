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
    public partial class MateriaPrimaAdmin : System.Web.UI.Page
    {
        MateriaPrima materiaPrima = new MateriaPrima();
        MateriaPrimaNegocio negocio = new MateriaPrimaNegocio();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!IsPostBack)
                { //pregunto si es la primera carga de la page


                    //esto es lo que necesitamos para el repeater.
                    dgvMaterial.DataSource = negocio.ListarMaterial();
                    dgvMaterial.DataBind();

                }
            
                dgvMaterial.RowStyle.CssClass = "font-weight-bold";
                if (negocio.ListarMaterial().Count() >= 1)
                {
                    dgvMaterial.HeaderRow.CssClass = "bg-primary";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void dgvMaterial_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                List<MateriaPrima> ListaMaterial = new List<MateriaPrima>();
                ListaMaterial = negocio.ListarMaterial();
                int index = Convert.ToInt32(e.CommandArgument);
                int idMaterial = Convert.ToInt32(dgvMaterial.Rows[index].Cells[0].Text);
                negocio.Eliminar(idMaterial);
                Response.Redirect("MateriaPrimaAdmin.aspx");
            }
            //if (e.CommandName == "Modificar")
            //{
            //    List<MateriaPrima> ListaProveedor = new List<MateriaPrima>();
            //    ListaMaterial = negocio.ListarMaterial();
            //    int index = Convert.ToInt32(e.CommandArgument);
            //    int idMaterial= Convert.ToInt32(dgvMaterial.Rows[index].Cells[0].Text);
            //    proveedor = ListaProveedor.Find(J => J.Id == idProducto);

            //    Session.Add(Session.SessionID + "modificar", proveedor);

            //    Response.Redirect("ModificarProveedor.aspx");
            //}
        }

        protected void dgvMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}