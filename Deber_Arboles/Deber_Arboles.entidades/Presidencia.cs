using System.Collections.Generic;

namespace Deber_Arboles.entidades
{
    public class Presidencia: Departamento
    {   
        public string NombrePresidente { get; set; }
        public string ApellidoPresidente { get; set; }
        public int AñosLabor { get; set; }

        internal int numeroEmpleado()
        {
            var totalEmpleados = 0;
            foreach (AsesorPresidencia asesorActual in AsesorPresidencia) 
            {
                totalEmpleados += asesorActual.nuemeroEmpleados();
            }

            foreach (GerenteGeneral gerenteActual in GerenteGeneral)
            {
                totalEmpleados += gerenteActual.nuemeroEmpleados();
            }
        }
    }
}
