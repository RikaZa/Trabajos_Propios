using System;
using System.Collections.Generic;
using Deber_Arboles.entidades;

namespace Deber_Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            var raiz = new Presidencia
            {
                Nombre = "Presidencia",
                Empleados = 1,
                NombrePresidente = "Jonathan",
                ApellidoPresidente = "Zambrano",
                AñosLabor = 10,
                Departamentos = new List<Departamento>
                {
                  new AsesorPresidencia
                  {
                       Nombre = "Asesor de Presidencia",
                       Empleados = 1,
                       NombreAsesor = "Juan",
                       ApellidoAsesor = "Chamorro",
                       Descripcion = "El puesto del presi es solo para la gente cool "
                  },
                  new GerenteGeneral
                  {
                       Nombre = "Gerente General",
                       NombreGerente = "Pedrito",
                       ApellidoGerente = "Loyola",
                       Empleados = 1,
                       Departamentos = new List<Departamento>
                       { 
                           new GerenteFinanzas
                           {
                               Nombre = "Gerente Finanzas",
                               NombreGFinanzas = "Irene",
                               ApellidoGFinanzas = "Torrez",
                               Empleados = 1,
                               Departamentos = new List<Departamento>
                               {
                                   new Contador
                                   {
                                        Nombre = "Contador",
                                        NombreContador = "Jhon",
                                        ApellidoContador = "Tanicuchi",
                                        Empleados = 1,
                                   },
                                   new AsistenteContador
                                   {
                                        Nombre = "Auxiliar de contador",
                                        NombreAsisContador = "Dylan",
                                        ApellidoAsisContador = " Lucio",
                                        Empleados = 1,
                                   }
                               }
                           },
                           new RecursosHumanos
                           {
                               Nombre = "Recursos Humanos",
                               NombreRRHH = "Shadira",
                               ApellidoRRHH = "Diaz",
                               Empleados = 1,
                           }
                       }
                  }
                }
            };
            int numero;
            Console.WriteLine("Hola ingresa el número según tu solicitud:\n1 = Saber Niveles.\n2 = Saber hojas.\n3 = Saber los nodos.");
            numero = int.Parse(Console.ReadLine());
            ControlMensajes control = new ControlMensajes();   
                switch (numero)     
                {        
                    case 1:
                        Console.WriteLine($" Los niveles son: {control.ContarNiveles(raiz, 1)}");
                        break;
                    case 2:
                        Console.WriteLine($" Las hojas son: {control.ContarHojas(raiz)}");
                        break;
                    case 3:
                        Console.WriteLine($" Los nodos son: {control.ContarNodos(raiz)}");
                        break;
                    default:
                        Console.WriteLine("No ingresaste una opción correcta");
                        break;
                }
   
           


           
            

        }
    }
}
