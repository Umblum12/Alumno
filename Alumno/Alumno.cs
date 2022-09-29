using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    internal class Alumno
    {
        //Propiedades
        private string Nombre;
        private int Edad;
        //Constructor
        public Alumno()
        {
            Nombre = "Abelardo Cruz Leos";
            Edad = 10;
        }
        //Metodos
        public void Imprimir_area_Triangulo()
        {
            Console.WriteLine("El Nombre del Alumno es: " + Nombre);
        }
        public void Imprimir_area_Trapecio()
        {
            Console.WriteLine("La edad del Alumno es: " + Edad);
        }
    }
}
