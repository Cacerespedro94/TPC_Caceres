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
    public partial class AltaMaterial : System.Web.UI.Page
    {
        MateriaPrima materiaPrima = new MateriaPrima();
        MateriaPrimaNegocio negocio = new MateriaPrimaNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                materiaPrima.Nombre = NombreBox.Text;
                materiaPrima.Descripcion = DescripcionBox.Text;
                materiaPrima.Stock = float.Parse(StockBox.Text);
                materiaPrima.proveedor.Id = int.Parse(ProveedorBox.Text);

                negocio.Agregar(materiaPrima);
               
                Response.Redirect("MateriaPrimaAdmin.aspx");


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}