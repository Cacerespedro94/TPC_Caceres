using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Venta
    {
        public Venta()
        {
            carro = new Carro();
            producto = new Articulo();
            cliente = new Cliente();

        }
        public int Id { get; set; }
        public Carro carro { get; set; }
        public Articulo producto { get; set; }
        public Cliente cliente { get; set; }
        public DateTime fecha { get; set; }
    }
}
