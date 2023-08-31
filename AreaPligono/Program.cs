using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Reto #4
 * ÁREA DE UN POLÍGONO
 * Fecha publicación enunciado: 24/01/22
 * Fecha publicación resolución: 31/01/22
 * Dificultad: FÁCIL
 *
 * Enunciado: Crea UNA ÚNICA FUNCIÓN (importante que sólo sea una) que sea capaz de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */

namespace AreaPligono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tipo de polígono: triangulo, cuadrado o rectangulo.");
            string poli = Console.ReadLine();
            Console.WriteLine("Introduce la longitud de la base:");
            double ladoBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la altura del poligono:");
            double alturaPoli = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El area del poligono es: " + Area(ladoBase, alturaPoli, poli));
        }

        static double Area(double lado1, double altura, string poligono)
        {       
            if (poligono.ToLower() == "triangulo")
            {
                return (lado1 * altura)/2;
            }
            else
            {
                return lado1 * altura;
            }
        }
    }
}
