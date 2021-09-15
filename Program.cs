using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            string Lado1, Lado2, Lado3;
            
            Console.WriteLine(" ");
            Console.Write(@"Olá usuário!
Calcularei, segundo a fórmula de "); 
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Heron da Alexandria");
            Console.ResetColor();
            Console.Write(@", a área de um
triangulo qualquer, do qual, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("você");
            Console.ResetColor();
            Console.WriteLine(" determinará o tamanho dos lados.");

            Console.WriteLine("Por favor tecle \"Enter\" para iniciar...");
            Console.ReadLine();
            
            Console.WriteLine("Digite os lados do triangulo desejado.");
            Console.WriteLine(" ");
            
            Console.Write("Lado 1..: ");
            Lado1 = Console.ReadLine();
            
            Console.Write("Lado 2..: ");
            Lado2 = Console.ReadLine();
            
            Console.Write("Lado 3..: ");
            Lado3 = Console.ReadLine();

            double Ld1 = Convert.ToDouble(Lado1);
            double Ld2 = Convert.ToDouble(Lado2);
            double Ld3 = Convert.ToDouble(Lado3);

            double p = (Ld1 + Ld2 + Ld3) / 2;

            double a = Math.Sqrt(p* (p-Ld1)*(p-Ld2)*(p-Ld3));

            Console.WriteLine($"Semiperímetro..: {p}");
            //Em alguns valores a área (variavel "a") exibe valor "NaN".
            Console.WriteLine($"Área...........: {a}");
        }
    }
}
