using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Calcular a área do terreno");
            Console.WriteLine("------------------------------\n");

            Console.WriteLine("Informe a Largura do terreno: ");
            int largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o comprimento do terreno: ");
            int comprimento = Convert.ToInt32(Console.ReadLine());

            CalcularArea(largura, comprimento);
        }
        static void CalcularArea(int largura, int comprimento)
        {
            int area = largura * comprimento;

            Console.WriteLine($@"Área = {area} m² ");

        }
    }


}
