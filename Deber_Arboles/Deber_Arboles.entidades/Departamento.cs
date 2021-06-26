using System.Collections.Generic;

namespace Deber_Arboles.entidades
{
    public class Departamento
    {   
        public string Nombre { get; set; }

        public int Empleados { get; set; }

        public List<Departamento> Departamentos { get; set; } = new List<Departamento>();


    }
}
