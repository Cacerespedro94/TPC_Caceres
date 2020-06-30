using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dominio
{
    public class Articulo
    {
        public Articulo()
        {
            Id = 0;
            Nombre = "";
            Descripcion = "";
            Categoria = new Categoria();
            sub = new SubCategoria();
            ImagenUrl = "";
            Precio = 0;
            CantidadUnidades = 1;
            Stock = 0;
            Eliminado = false;
        }
        public Int64 Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Categoria Categoria { get; set; }
        public SubCategoria sub { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
        public int CantidadUnidades { get; set; } 
        public bool Eliminado { get; set; }
        public int Stock { get; set; }
    }
   
}

