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
    public partial class Carrito : System.Web.UI.Page
    {
        public List<Articulo> listaProductos { get; set; }
        public Carro prue = new Carro();
        List<Articulo> listaArticulo;
        Articulo ar = new Articulo();
        ArticuloNegocio negocio = new ArticuloNegocio();
        Cliente cliente = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

                if (Session[Session.SessionID + "elemento"] != null)
                {
                    
                    prue = (Carro)Session[Session.SessionID + "elemento"];
                
                    dgvCarrito.DataSource = prue.Item;
                    dgvCarrito.DataBind();
                    dgvCarrito.RowStyle.CssClass = "font-weight-bold";
                    
                    Total.Text = "$" + prue.SubTotal.ToString();
                    if (prue.Cantidad == 1)
                    {
                        CanUni.Text = "Estás llevando " + prue.Cantidad + " unidad...";
                    }
                    else
                    {
                        CanUni.Text = "Estás llevando " + prue.Cantidad + " unidades...";
                    }
                    if (prue.Cantidad > 0)
                    {
                        dgvCarrito.HeaderRow.CssClass = "bg-primary";
                    }
                }

        
            }


            catch (Exception)
            {

                throw;
            }

        }

        protected void dgvCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dgvCarrito_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int idProducto = Convert.ToInt32(dgvCarrito.Rows[index].Cells[0].Text);
            ar = prue.Item.Find(J => J.Id == idProducto);

            if (e.CommandName == "Select")
            {

                prue.SubTotal -= ar.Precio* ar.CantidadUnidades;
                prue.Cantidad--;
                prue.Item.Remove(ar);
                Response.Redirect("Carrito.aspx");
            }
            if(e.CommandName == "Agregar")
            {
                prue.Cantidad++;
                ar.CantidadUnidades++;
                prue.SubTotal += ar.Precio;
                Response.Redirect("Carrito.aspx");
            }
            if (e.CommandName == "Restar")
            {
                if(ar.CantidadUnidades!=1)
                {
                    prue.Cantidad--;
                    prue.SubTotal -= ar.Precio;
                    ar.CantidadUnidades--;
                    Response.Redirect("Carrito.aspx");
                }
            }
        }

        protected void btnSeguir_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            VentaNegocio negocio = new VentaNegocio();
            List<Venta> listaVenta = new List<Venta>();
            Venta aux = new Venta();
            int contador = 0;
            cliente = (Cliente)Session[Session.SessionID + "Cliente"];
                if (Session[Session.SessionID + "Cliente"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if (cliente.direccion.Id == 0)
            {
                Response.Redirect("AgregarDireccion");
            }
            else
            {
               venta.cliente = (Cliente)Session[Session.SessionID + "Cliente"];
               venta.carro = (Carro)Session[Session.SessionID + "elemento"];
                venta.fecha = DateTime.Now.Date;
                foreach (var item in venta.carro.Item)
                {
                    venta.producto = item;
                    if (contador == 0)
                    {
                        negocio.AgregarVenta(venta);
                        listaVenta = negocio.ListarVentas();

                        contador++;
                    }
                    aux = listaVenta[listaVenta.Count - 1];
                    venta.Id = aux.Id;
                   
                    negocio.AgregarProductos_Por_Ventas(venta);
                }
                
                negocio.Ventas_x_Usuario(venta);
                Response.Redirect("Default.aspx");
            }
        }
    }
}