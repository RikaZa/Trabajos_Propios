using Deber_Arboles.entidades;
using System.Linq;

namespace Deber_Arboles

{
    class ControlMensajes
    {
        int altura = 0;
        public  int ContarNiveles(Departamento raiz, int nivel)
        {
            if (raiz != null)
            {
                foreach (Departamento departamentoActual in raiz.Departamentos)
                {
                    ContarNiveles(departamentoActual, nivel + 1);
                    if (nivel > altura)
                    {
                        altura = nivel;
                    }
                }
                
            }
            return altura + 1; 
        }

        internal int ContarHojas(Departamento raiz)
        {
            if (SoyHoja(raiz))
                return 1;

            int totalHojas = 0;
            foreach (var hijoActual in raiz.Departamentos)
            {
                totalHojas += ContarHojas(hijoActual);
            }
            return totalHojas;
        }
        internal int ContarNodos(Departamento raiz)
        {
            if (SoyHoja(raiz))
                return 1;

            int totalNodos = 0;

            foreach (var nodoActual in raiz.Departamentos)
            {
                totalNodos += ContarNodos(nodoActual);
            }
            return totalNodos + 1;
        }
        private bool SoyHoja(Departamento raiz)
        {
            return !raiz.Departamentos.Any();
        }   

    }
}
