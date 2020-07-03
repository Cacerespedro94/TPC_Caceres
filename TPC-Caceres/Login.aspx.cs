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

     

            Usuario usuario = new Usuario();
            ClienteNegocio negocio = new ClienteNegocio();
            List<Usuario> listaUsuario = new List<Usuario>();

            listaUsuario = negocio.ListarClientes();
            

            //administrador = listaAdministrador.Find(J => J.User.Login == Email && J.User.Password == Contraseña);

            usuario = listaUsuario.Find(J => J.Login == Email && J.Password == Contraseña);
           
            if (usuario != null)
            {
                Session.Add(Session.SessionID + "Usuario", usuario);
                Response.Redirect("Default.aspx");
                         
            }
      
           else
            {
                listaUsuario = negocio.ListarUsuario();
                usuario = listaUsuario.Find(J => J.Login == Email && J.Password == Contraseña);
                if (usuario.TipoUsuario == 1)
                {
                    Session.Add(Session.SessionID + "Usuario", usuario);
                    Response.Redirect("InicioAdmin.aspx");
                }
                else
                {
                    lblError.Text = "Email o contraseña incorrectos";
                }
            }
            



        }
    }
}