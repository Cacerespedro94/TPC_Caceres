using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_Caceres
{
    public partial class ModificarProveedor : System.Web.UI.Page
    {
        Proveedor proveedor = new Proveedor();
        ProveedorNegocio negocio = new ProveedorNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session[Session.SessionID + "modificar"] != null)
                {
                    proveedor = (Proveedor)Session[Session.SessionID + "modificar"];
                    NombreBox.Text = proveedor.Nombre;
                    CalleBox.Text = proveedor.direccion.Calle;
                    AlturaBox.Text = Convert.ToString(proveedor.direccion.Altura);
                    CodigoBox.Text = proveedor.direccion.CodigoPostal;
                    ProvinciaBox.Text = proveedor.direccion.Provincia;
                    LocalidadBox.Text = proveedor.direccion.Localidad;
                    EmailBox.Text = proveedor.contacto.Email;
                    TelefonoBox.Text = Convert.ToString(proveedor.contacto.Telefono);
                }
            }
        }

        protected void Agregar_Click(object sender, EventArgs e)
        { 
            Contacto contacto = new Contacto();
            ContactoNegocio contactoNegocio = new ContactoNegocio();
            Direccion direccion = new Direccion();
            DireccionNegocio direccionNegocio = new DireccionNegocio();
            proveedor = (Proveedor)Session[Session.SessionID + "modificar"];
            int IdDireccion;
            int IdContacto;
            
            direccion.Calle = CalleBox.Text;
            direccion.Altura = Convert.ToInt32(AlturaBox.Text);
            direccion.CodigoPostal = CodigoBox.Text;
            direccion.Provincia = ProvinciaBox.Text;
            direccion.Localidad = LocalidadBox.Text;
            contacto.Email = EmailBox.Text;
            contacto.Telefono = TelefonoBox.Text;

            if (direccionNegocio.SiExisteDireccion(direccion)==true)
            {
                IdDireccion = direccionNegocio.BuscarIdDireccion(direccion);
            }
            else
            {
                direccionNegocio.Agregar(direccion);
                IdDireccion = direccionNegocio.BuscarIdDireccion(direccion);

            }

            if (contactoNegocio.SiExisteContacto(contacto))
            {
                IdContacto = contactoNegocio.BuscarIdContacto(contacto);
            }
            else
            {
                contactoNegocio.Agregar(contacto);
                IdContacto = contactoNegocio.BuscarIdContacto(contacto);

            }


            proveedor.Nombre = NombreBox.Text;
            proveedor.direccion.Id = IdDireccion;
            proveedor.contacto.Id = IdContacto;



            negocio.modificar(proveedor);
            Response.Redirect("ProveedorAdmin.aspx");


        }
    }
}