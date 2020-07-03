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
    public partial class ClienteCompra : System.Web.UI.Page
    {
        VentaNegocio negocio = new VentaNegocio();
        Usuario cliente = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
           cliente = (Usuario)Session[Session.SessionID + "Usuario"];
            //DgvClienteVenta.DataSource = negocio.ListarVentasCliente(cliente);
            //DgvClienteVenta.DataBind();

            DgvCompra.DataSource = negocio.ListarCompras(cliente);
            DgvCompra.DataBind();

            if (!IsPostBack)
            { //pregunto si es la primera carga de la page


                //esto es lo que necesitamos para el repeater.
      
            }
        }

        protected void DgvCompra_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            cliente = (Usuario)Session[Session.SessionID + "Usuario"];

            if (e.CommandName == "Detalle")
            {


                int IdCliente = cliente.Id;
                int index = Convert.ToInt32(e.CommandArgument);
                int IdVenta = Convert.ToInt32(DgvCompra.Rows[index].Cells[0].Text);
                List<Venta> listaVenta = new List<Venta>();
                listaVenta = negocio.ListarVentasCliente(IdVenta);
                Session.Add(Session.SessionID + "ListaVenta", listaVenta);

                Response.Redirect("DetalleCompra.aspx");
            }
            //= negocio.ListarCompras(cliente).Find(J => J.Id == IdVenta);

        }

        protected void DgvCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            
            //aux.producto.Nombre = datos.lector.GetString(0);
            //aux.producto.Precio = datos.lector.GetDecimal(1);
            //aux.fecha = datos.lector.GetDateTime(2);
            //aux.Id = datos.lector.GetInt32(3);
            //aux.producto.CantidadUnidades = datos.lector.GetInt32(4);
        }
    }
}