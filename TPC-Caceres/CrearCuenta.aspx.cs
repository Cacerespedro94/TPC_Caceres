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
    public partial class CrearCuenta : System.Web.UI.Page
    {
        Cliente cliente = new Cliente();
        ClienteNegocio clientenegocio = new ClienteNegocio();
        
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
                int IdDireccion=0;
                int IdContacto=0;
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

                cliente.Dni = Convert.ToInt64(DniBox.Text);
                cliente.Nombre = NombreBox.Text;
                cliente.Apellido = ApellidoBox.Text;
                cliente.User.Login = NombreUsuarioBox.Text;
                cliente.User.Password = ContraseñaBox.Text;
                cliente.direccion.Id = IdDireccion;
                cliente.contacto.Id = IdContacto;


                clientenegocio.Agregar(cliente);


            }
            catch (Exception ex)
            {

                throw ex;
            }

            

        }
    }
}