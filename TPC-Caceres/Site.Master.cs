using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_Caceres
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session[Session.SessionID + "Cliente"] == null)
            {
                Cuenta.Visible = false;
                Iniciar.Visible = true;
                CerrarLINK.Visible = false;
            }
            else
            {
                Cuenta.Visible = true;
                Iniciar.Visible = false;
            }
        }

        protected void CerrarLINK_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }


        protected void Cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Seleccionado;
            Seleccionado = Cuenta.SelectedItem.Text;
        }

        protected void Iniciar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearCuenta.aspx");
        }
    }
}