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
    public partial class ventasAdmin : System.Web.UI.Page
    {
        VentaNegocio negocio = new VentaNegocio();
        Cliente cliente = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {
                //cliente = (Cliente)Session[Session.SessionID + "Cliente"];

                //DgvClienteVenta.DataSource = negocio.ListarVentasCliente(cliente);
                //DgvClienteVenta.DataBind();

                DgvVenta.DataSource = negocio.ListarVentasAdministrador();
                DgvVenta.DataBind();

                if (!IsPostBack)
                { //pregunto si es la primera carga de la page


                    //esto es lo que necesitamos para el repeater.

                }
        }

        protected void DgvVenta_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void DgvVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}