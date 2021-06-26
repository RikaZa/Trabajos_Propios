using System;
using System.Collections.Generic;

namespace Deber_Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arbol!!");
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

    class Nodo
    { 
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
    }
}
