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
        Usuario cliente = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

                if (Session[Session.SessionID + "elemento"] != null)
                {
                    btnSeguir.Visible = true;
                    CarroVacio.Visible = false;
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
                else
                {
                    btnSeguir.Visible = false;
                    CarroVacio.Visible = true;
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

                prue.SubTotal -= ar.Precio * ar.CantidadUnidades;
                prue.Cantidad--;
                prue.Item.Remove(ar);
                Response.Redirect("Carrito.aspx");
            }
            if (e.CommandName == "Agregar")
            {
                prue.Cantidad++;
                ar.CantidadUnidades++;
                prue.SubTotal += ar.Precio;
                Response.Redirect("Carrito.aspx");
            }
            if (e.CommandName == "Restar")
            {
                if (ar.CantidadUnidades != 1)
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
            cliente = (Usuario)Session[Session.SessionID + "Usuario"];
            if (Session[Session.SessionID + "Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (cliente.direccion.Calle == "Sin datos")
            {
                Response.Redirect("AgregarDireccion.aspx");
            }
            else
            {
                venta.cliente = (Usuario)Session[Session.SessionID + "Usuario"];
                venta.carro = (Carro)Session[Session.SessionID + "elemento"];
                venta.fecha = DateTime.Now.Date;

                foreach (var item in venta.carro.Item)
                {
                    Articulo producto = new Articulo();
                    ArticuloNegocio negocioArticulo = new ArticuloNegocio();
                    producto = negocioArticulo.ListarArticulos().Find(k => k.Id == item.Id);
                    if (item.CantidadUnidades <= producto.Stock)
                    {
                        producto.Stock = producto.Stock - item.CantidadUnidades;
                        negocioArticulo.ModificarStockProducto(producto);
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
                    else
                    {
                        Response.Redirect("Default.aspx");
                        break;
                    }

                }

                negocio.Ventas_x_Usuario(venta);
                Response.Redirect("ClienteCompra.aspx");
            }
        }
    }
}