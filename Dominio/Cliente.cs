﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  
   public class Cliente:Persona
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public Contacto Contact { get; set; }
    }
}