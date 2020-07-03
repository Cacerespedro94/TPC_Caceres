using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Persona
    {   public Persona()
        {
            direccion = new Direccion();
            contacto = new Contacto();
            dni = "Sin datos";
        }
                
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string dni { get; set; }
        public Direccion direccion { get; set; }
        public Contacto contacto { get; set; }


    }
}
