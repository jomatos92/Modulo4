using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o valor: ");
            var val = Console.ReadLine();
            Console.WriteLine("Introduza o caracter: ");
            var cha = Console.Read();
            Console.WriteLine("Introduza a tecla: ");
            var tec = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Valor " +val + "\nCaracter " +cha + "\nTecla " +tec.Key);
            Console.WriteLine($"\nValor { val} \nCaracter { cha} \nTecla + { tec.Key}");
            Console.WriteLine(@"Valor { 0} \n Caracter { 1} \n Tecla { 2}", val, cha, tec.Key);

        }
    }
}
