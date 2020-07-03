using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario : Persona
    {
        public Usuario(){
            TipoUsuario = 0;

            }
        public string Login{ get; set; }
        public string Password { get; set; }
        public int TipoUsuario { get; set; }
        public string TipoUsuarioNombre { get; set; }
        public bool Eliminado { get; set; }
    }
}
