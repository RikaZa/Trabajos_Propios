using System;

namespace Deber_Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del Arbol!!");
            Nodo padre = new Nodo
            {
                Valor = "Precidencia",
                Hijos =
                { 
                    new Nodo
                    {
                        Valor = "Asesor de presidencia" 
                    }, 
                    new Nodo 
                    { 
                        Valor = "Gerente General",
                        Hijos =
                        {
                            new Nodo
                            { 
                                Valor = "Grente de Finanzas",
                                Hijos =
                                {
                                    new Nodo { Valor = "Contador"},
                                    new Nodo { Valor = " Asistente de contador"}
                                }
                            },
                            new Nodo
                            {
                                Valor = " Recursos Humanos"
                            }
                        }  
                    }
                }
            };
        }
    }
    class ManejoMensajes
    {
        
    }

    class ContadorNiveles
    {

    }

    class ContadorHojas
    {
        
    }

    class ContadorNodos 
    {


    }
}
