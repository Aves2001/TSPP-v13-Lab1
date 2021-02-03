using System;

namespace Lab1
{
    public class Program
    {
        private static void Main()
        {
            string str;
            double a;
            
            do
            {
                Console.WriteLine("\nВведіть довжину ребра куба:");

                str = Console.ReadLine();
                a = double.Parse(str);

                if (a == 0)
                {
                    Console.WriteLine("\n[Error] Довжина ребра куба = 0\n");
                }
                else if (a < 1)
                {
                    Console.WriteLine("\n[Error] Довжина ребра куба < 1\n");
                }
            } while (a < 1);
            
            Console.WriteLine();
            
            RibToCubeV(a); //Обчислює обєм[V] куба по довжині його ребра[a]
            RibToCubeS(a); //Обчислює площю[S] поверхні куба по довжині його ребра[a]

            Console.ReadLine(); //pause
        }

        public static double RibToCubeV(double a) //Обчислює обєм[V] куба по довжині його ребра[a]
        {
            double V = a * a * a;
            Console.WriteLine("Об’єм куба = " + V);
            return V;
        }

        public static double RibToCubeS(double a) //Обчислює площю[S] поверхні куба по довжині його ребра[a]
        {
            double S = a * a * 6;
            Console.WriteLine("Площа поверхні куба = " + S);
            return S;
        }
    }
}
