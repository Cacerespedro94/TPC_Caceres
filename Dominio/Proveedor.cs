using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{

  public  class Proveedor
    {
        public Proveedor()
        {
            contacto = new Contacto();
            direccion = new Direccion();
            Eliminado = false;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Contacto contacto { get; set; }
        public Direccion direccion { get; set; }
        public bool Eliminado { get; set; }
    }
}
