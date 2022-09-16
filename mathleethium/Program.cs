    using System;

namespace mathleethium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Random z = new Random();
            for (int i = 0; i < 100; i++)
            {
                a[i] = z.Next(0, 1001);
                Console.Write("{0,2} ", a[i]);
            }
            Console.WriteLine();
            int min = a[0];
            for (int i = 1; i < 100; i++)
                min = Math.Min(min, a[i]);
            

            int max = a[0];
            for (int i = 1; i < 100; i++)
                max = Math.Max(max, a[i]);

            Console.WriteLine("Показать максимальное значение - Макс");
            Console.WriteLine("Показать минимальное значение - Мин");

            string lang = Console.ReadLine();
            switch (lang)
            {
                case "Макс":
                    Console.WriteLine(+ max + " - Максимальное число");
                    break;
                case "Мин":
                    Console.WriteLine(+ min + " - Минимальное число");
                    break;


            }


        }
    }
}
