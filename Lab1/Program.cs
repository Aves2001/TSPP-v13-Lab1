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
            
            _ = CubeRibArea(a); //Обчислює обєм[V] куба по довжині його ребра[a]
            _ = SurfaceAreaCube(a); //Обчислює площю[S] поверхні куба по довжині його ребра[a]

            _ = Console.ReadLine(); //pause
        }

        public static double CubeRibArea(double a) //Обчислює обєм[V] куба по довжині його ребра[a]
        {
            double V = a * a * a;
            Console.WriteLine("Об’єм куба = " + V);
            return V;
        }

        public static double SurfaceAreaCube(double a) //Обчислює площю[S] поверхні куба по довжині його ребра[a]
        {
            double S = a * a * 6;
            Console.WriteLine("Площа поверхні куба = " + S);
            return S;
        }
    }
}
