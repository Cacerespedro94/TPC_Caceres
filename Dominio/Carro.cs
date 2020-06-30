using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{

    public class Carro
    {
        public Carro()
        {
            Item = new List<Articulo>();
            Cantidad = 0;
            SubTotal = 0;
           
        }
        public int Id { get; set; }
        public List<Articulo> Item { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        
    }
}
