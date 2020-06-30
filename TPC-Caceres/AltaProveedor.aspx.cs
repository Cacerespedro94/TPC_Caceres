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
    public partial class AltaProveedor : System.Web.UI.Page
    {
        Proveedor proveedor = new Proveedor();
        ProveedorNegocio proveedorNegocio = new ProveedorNegocio();

        Direccion direccion = new Direccion();
        DireccionNegocio direccionNegocio = new DireccionNegocio();

        Contacto contact = new Contacto();
        ContactoNegocio contactoNegocio = new ContactoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdDireccion = 0;
                int IdContacto = 0;
                direccion.Calle = CalleBox.Text;
                direccion.Altura = Convert.ToInt32(AlturaBox.Text);
                direccion.Provincia = ProvinciaBox.Text;
                direccion.CodigoPostal = CodigoBox.Text;
                direccion.Localidad = LocalidadBox.Text;



                direccionNegocio.Agregar(direccion);
                //Busca el Id de la direccion Agregada.


                IdDireccion = direccionNegocio.BuscarIdDireccion(direccion);

                contact.Email = EmailBox.Text;
                contact.Telefono = TelefonoBox.Text;

                contactoNegocio.Agregar(contact);

                IdContacto = contactoNegocio.BuscarIdContacto(contact);

               
                proveedor.Nombre = NombreBox.Text;
                proveedor.direccion.Id = IdDireccion;
                proveedor.contacto.Id = IdContacto;


                proveedorNegocio.Agregar(proveedor);
                Response.Redirect("ProveedorAdmin.aspx");


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}