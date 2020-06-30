using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public  class MateriaPrima
    {
        public MateriaPrima()
        {
            proveedor = new Proveedor();
            Eliminado = false;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Proveedor proveedor { get; set; }
        public double Stock { get; set; }
        public bool Eliminado { get; set; }
        
    }
}
