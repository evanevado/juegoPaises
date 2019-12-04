using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego.src.LibreriasJuego
{
    public class Dummy
    {
        public static void Main()
        {
            pintarEvaluacion(cuadrado, 5);
            //equivale a
            pintarEvaluacion((j)=>j*j,5);
            //le pongo j como cualquier nombre... estoy diciendo que recibe un parámetro y lo que tiene que hacer con él
        }

        public static int cuadrado(int x)
        {
            return x * x;
        }

        public static void pintarEvaluacion(Func<int, int> funcion, int x)
        {
            int resultado = funcion(x);
            Console.WriteLine("El resultado es " + resultado);
        }
    }
}
