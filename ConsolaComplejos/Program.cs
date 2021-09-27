using System;
using ComplejosLibreria;
namespace ConsolaComplejos
{
    class Program
    {
        static void Main(string[] args)
        {
            Complejo c1 = new Complejo(2,5);
            Complejo c2 = new Complejo(3, 7);
            Complejo c3 = c1 + c2;

            Console.WriteLine("{0}  +  {1}  = {2} ", c1, c2, c3);
            Console.ReadLine();

        }
    }
}
