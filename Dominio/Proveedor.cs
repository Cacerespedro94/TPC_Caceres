﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public  class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Contacto contacto { get; set; }
        public Direccion direccion { get; set; }
    }
}