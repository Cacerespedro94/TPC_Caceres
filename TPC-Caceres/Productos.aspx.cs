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
    public partial class Productos : System.Web.UI.Page
    {
        
        public List <Articulo> listaProductos { get; set; }
        public Carro prue = new Carro();
        List<Articulo> listaArticulo;
        Articulo ar = new Articulo();
        ArticuloNegocio negocio = new ArticuloNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                listaProductos = negocio.ListarArticulos();

                listaArticulo = negocio.ListarArticulos();

                if (!IsPostBack)
                { //pregunto si es la primera carga de la page


                    //esto es lo que necesitamos para el repeater.
                    repetidor.DataSource = listaProductos;
                    repetidor.DataBind();

                }
                //else
                //{

                //    if (txtBuscador.Text != "")
                //    {
                //        repetidor.DataSource = (List<Articulo>)Session[Session.SessionID + "filtrado"];
                //        repetidor.DataBind();

                //    }
                //    else
                //    {
                //        repetidor.DataSource = listaProductos;
                //        repetidor.DataBind();
                //    }
                //}

            }

            catch (Exception)
            {
                throw;
            }
        }

        protected void btnargumento_Click(object sender, EventArgs e)
        {
            CarritoNegocio carrito = new CarritoNegocio();
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                var articuloSeleccionado = Convert.ToInt32(((Button)sender).CommandArgument);
                ar = listaArticulo.Find(J => J.Id == articuloSeleccionado);

                if (Session[Session.SessionID + "elemento"] != null)
                {
                    prue = (Carro)Session[Session.SessionID + "elemento"];
                }
                if (!prue.Item.Exists(A => A.Id == ar.Id))
                {

                    prue.Item.Add(ar);
                    prue.SubTotal += ar.Precio;
                    prue.Cantidad++;
                    Session.Add(Session.SessionID + "elemento", prue);
                }
                {

                }
                Response.Redirect("Productos.aspx");
            }
            catch (Exception)
            {

            }
        }
    }
}