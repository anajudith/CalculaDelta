using System;

class MainClass 
{
  static void Main(string[] args)
        {
            double a, b, c;
            double Delta;
            double Raiz1, Raiz2;

            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());

            Delta = CalcDelta(a, b, c);

            Console.WriteLine($"\nDelta = {Delta:F2}");     // Ou Console.WriteLine("\nDelta = {0:F2}", Delta);

            Console.ReadKey();

            Raiz1 = 0;
            Raiz2 = 0;

            if (Delta < 0)
            {
                Console.WriteLine("\nNão existem Raízes Reais na Equação...\n");
            }
            else
            {
                CalcRaízes(a, b, Delta, ref Raiz1, ref Raiz2);

                Console.WriteLine("\nRaiz 1 = {0:F2}", Raiz1);
                Console.WriteLine("Raiz 2 = {0:F2}\n", Raiz2);
            }

            Console.ReadKey();
        }

        static double CalcDelta(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        static void CalcRaízes(double a, double b, double Delta, ref double R1, ref double R2)
        {
            R1 = (-b + Math.Sqrt(Delta)) / (2 * a);
            R2 = (-b - Math.Sqrt(Delta)) / (2 * a);
        }
}
