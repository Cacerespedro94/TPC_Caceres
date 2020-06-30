using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Administrador:Persona
    {
        public Administrador()
        {
            User = new Usuario();
        }
        public bool Eliminado { get; set; }
    }
}
