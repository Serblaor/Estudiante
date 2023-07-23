using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular el área y el perímetro de un círculo");

            // Solicitar al usuario ingresar el radio del círculo
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            // Crear una instancia de la clase Circulo
            Circulo circulo = new Circulo();

            // Asignar el radio ingresado a la propiedad correspondiente
            circulo.Radio = radio;

            // Mostrar el área y el perímetro del círculo
            Console.WriteLine("El área del círculo es: " + circulo.Area);
            Console.WriteLine("El perímetro del círculo es: " + circulo.Perimetro);

            Console.ReadLine();
        }
    }
}
