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
            
            if (Session[Session.SessionID + "Usuario"] == null)
            {
                navbarDropdown.Visible = false;
                Iniciar.Visible = true;
                CerrarLINK.Visible = false;
            }
            else
            {   
                navbarDropdown.Visible = true;
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
          
        }

        protected void Iniciar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}