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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Session.SessionID + "Usuario"] == null)
            {
                btnCrearUsuario.Visible = true;
                btnIniciarSesion.Visible = true;
                
                
                
            }
            else
            {
                btnCrearUsuario.Visible = false;
                btnIniciarSesion.Visible = false;
            }
        }
    }
}