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
    public partial class DetalleCompra : System.Web.UI.Page
    {
        List<Venta> ListaVenta = new List<Venta>();
        protected void Page_Load(object sender, EventArgs e)
        {
          ListaVenta = (List<Venta>)Session[Session.SessionID + "ListaVenta"];
          
            if (!IsPostBack)
            { //pregunto si es la primera carga de la page


                //esto es lo que necesitamos para el repeater.
                repetidor.DataSource = ListaVenta;
                repetidor.DataBind();

            }
        }
    }
}