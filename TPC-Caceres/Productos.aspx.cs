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
    public partial class Productos : System.Web.UI.Page
    {
        public List <Articulo> listaProductos { get; set; }
        public Carrito prue = new Carrito();
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
    }
}