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
    public partial class ventasAdmin : System.Web.UI.Page
    {
        VentaNegocio negocio = new VentaNegocio();
        List<Venta> listaVentas = new List<Venta>();
        Cliente cliente = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {
                //cliente = (Cliente)Session[Session.SessionID + "Cliente"];

                //DgvClienteVenta.DataSource = negocio.ListarVentasCliente(cliente);
                //DgvClienteVenta.DataBind();


            if (!IsPostBack)
            { //pregunto si es la primera carga de la page

                DgvVenta.DataSource = negocio.ListarVentasAdministrador();
                DgvVenta.DataBind();
                DgvVenta.RowStyle.CssClass = "font-weight-bold";

                if (negocio.ListarVentasAdministrador().Count> 0)
                {
                    DgvVenta.HeaderRow.CssClass = "bg-primary";
                }

            }
            else
            {
                if (txtBuscador.Text != "")
                {
                    DgvVenta.DataSource = (List<Venta>)Session[Session.SessionID + "filtrado"];
                    DgvVenta.DataBind();

                }
                else
                {
                    DgvVenta.DataSource = negocio.ListarVentasAdministrador();
                    DgvVenta.DataBind();
                }

                if (negocio.ListarVentasAdministrador().Count() >= 1)
                {
                    DgvVenta.HeaderRow.CssClass = "bg-primary";
                }
            }
        }


        protected void DgvVenta_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //cliente = (Usuario)Session[Session.SessionID + "Usuario"];

            if (e.CommandName == "Detalle")
            {


                int IdCliente = cliente.Id;
                int index = Convert.ToInt32(e.CommandArgument);
                int IdVenta = Convert.ToInt32(DgvVenta.Rows[index].Cells[0].Text);
             
                listaVentas = negocio.ListarVentasCliente(IdVenta);
                Session.Add(Session.SessionID + "ListaVenta", listaVentas);

                Response.Redirect("DetalleVentaAdmin.aspx");
            }
            //= negocio.ListarCompras(cliente).Find(J => J.Id == IdVenta);
        }
        protected void Buscador_TextChanged(object sender, EventArgs e)
        {
            List<Venta> listaFiltrada;

            try
            {
                listaVentas = negocio.ListarVentasAdministrador();
                if (txtBuscador.Text == "")
                {
                    listaFiltrada = listaVentas;
                    Session.Add(Session.SessionID + "filtrado", listaFiltrada);
                    DgvVenta.DataSource = listaFiltrada;
                    DgvVenta.DataBind();

                }
                else
                {
                    listaFiltrada = listaVentas.FindAll(k => k.cliente.Nombre.ToLower().Contains(txtBuscador.Text.ToLower()) ||

                      k.cliente.Apellido.ToLower().Contains(txtBuscador.Text.ToLower()));
                    
                    Session.Add(Session.SessionID + "filtrado", listaFiltrada);
                    DgvVenta.DataSource = listaFiltrada;
                    DgvVenta.DataBind();
                    if (DgvVenta.DataSource != null)
                    {
                        DgvVenta.HeaderRow.CssClass = "bg-primary";
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void DgvVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}