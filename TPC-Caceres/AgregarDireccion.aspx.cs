using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
namespace TPC_Caceres
{
    public partial class AgregarDireccion : System.Web.UI.Page
    {
        Direccion direccion = new Direccion();
        DireccionNegocio direccionNegocio = new DireccionNegocio();
        Cliente cliente = new Cliente();
        ClienteNegocio clienteNegocio = new ClienteNegocio();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Session.SessionID + "Cliente"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            int IdDireccion = 0;

            direccion.Calle = CalleBox.Text;
            direccion.Altura = Convert.ToInt32(AlturaBox.Text);
            direccion.Provincia = ProvinciaBox.Text;
            direccion.CodigoPostal = CodigoBox.Text;
            direccion.Localidad = LocalidadBox.Text;
            cliente.Dni = Convert.ToInt64(DniBox.Text);

            cliente = (Cliente)Session[Session.SessionID + "Cliente"];

            
            //Busca el Id de la direccion Agregada.
            
            if(!direccionNegocio.SiExisteDireccion(direccion))
            {
                direccionNegocio.Agregar(direccion);
            }
            IdDireccion = direccionNegocio.BuscarIdDireccion(direccion);
            cliente.direccion.Id = IdDireccion;
            clienteNegocio.modificar(cliente);
            Response.Redirect("Productos.aspx");
        }
    }
}