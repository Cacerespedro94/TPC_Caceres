using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class SubCategoria
    {       
            public SubCategoria()
        {
            Id = 0;
            Nombre = "";
            Eliminado = false;
        }
            public int Id { get; set; }
            public string Nombre { get; set; }
            public bool Eliminado { get; set; }
        public override string ToString()
            {
                return Nombre;
            }
        }
    }

