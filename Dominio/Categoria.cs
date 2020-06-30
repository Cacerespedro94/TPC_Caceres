using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Categoria
    {   public Categoria()
        {
        
            
            Eliminado = false;

        }
        public Int64 Id { get; set; }
        public string Nombre { get; set; }
        public bool Eliminado { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
