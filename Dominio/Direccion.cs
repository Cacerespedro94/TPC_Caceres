using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Direccion
    {
        public Direccion()
        {
            Id = 0;
            Calle = "Sin datos";
            Altura = 0;
            CodigoPostal = "Sin datos";
            Provincia = "Sin datos";
            Localidad = "Sin datos";
            Departamento = "Sin datos";



        }
        public int Id { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CodigoPostal { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string Departamento { get; set; }


    }
}
