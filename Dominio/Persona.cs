﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Persona
    {   
        public int Id { get; set; }
        public Int64 Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Usuario User { get; set; }

    }
}
