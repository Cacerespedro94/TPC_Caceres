using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Dominio
{
   public class Contacto
    {
        public Contacto()
        {
            Id = 0;
            Email = "Sin datos";
            Telefono = "Sin datos";
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
