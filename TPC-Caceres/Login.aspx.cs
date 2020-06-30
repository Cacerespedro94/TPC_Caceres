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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string Email = EmailBox.Text.Trim();
            ContraseñaBox.Attributes["type"] = "text";
            
            string Contraseña = ContraseñaBox.Text;

            Administrador administrador = new Administrador();
            AdministradorNegocio administradorNegocio = new AdministradorNegocio();

            List<Administrador> listaAdministrador = new List<Administrador>();
            listaAdministrador = administradorNegocio.ListarAdministrador();

            Cliente cliente = new Cliente();
            ClienteNegocio negocio = new ClienteNegocio();
            List<Cliente> listacliente = new List<Cliente>();

            listacliente = negocio.ListarClientes();

            administrador = listaAdministrador.Find(J => J.User.Login == Email && J.User.Password == Contraseña);

            cliente = listacliente.Find(J => J.User.Login == Email && J.User.Password == Contraseña);
           
            if (cliente != null)
            {
                Session.Add(Session.SessionID + "Cliente", cliente);
                Response.Redirect("Default.aspx");
            
            }
            if(administrador!= null)
            {
                Session.Add(Session.SessionID + "Administrador", administrador);
                Response.Redirect("InicioAdmin.aspx");
            }
           else
            {
                lblError.Text = "Email o contraseña incorrectos";
            }
            


        }
    }
}