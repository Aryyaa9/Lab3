using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../Input.txt";
            string path2 = "../../../Output.txt";

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(ai());
            }

            using (StreamReader reader = new StreamReader(path))
            {
                int[] numbers = reader.ReadToEnd().Split(' ').Select(int.Parse).ToArray();


                using (StreamWriter writer2 = new StreamWriter(path2, false))
                {
                    writer2.Write(output(numbers));
                }
            }
        }

        static string ai()
        {
            string str = "";
            Console.Write("Введите выбранные числа: ");
            str = Console.ReadLine();
            return str;
        }

        static string output(int[] numbers)
        {
            string str = "";

            Console.Write("Введите кол-во билетов: ");
            int n = int.Parse(Console.ReadLine());
            
            
            //генерация n билетов с 6 числами
            for (int i = 0; i < n; i++)
            {
                int[] num6 = new int[6];
                Random rand = new Random();
                for (int j = 0; j < 6; j++)
                {
                    num6[j] = rand.Next(1, 32);
                }

                int CheckTicket = 0;
                foreach (var ai in numbers) // 10 выбранных чисел
                {
                    foreach (var bj in num6) // числа из билетов
                    {
                        if (ai == bj)
                        {
                            CheckTicket++;
                        }
                    }
                }

                foreach (var el in num6)
                {
                    str += el + " ";
                }

                
                if (CheckTicket >= 3)
                {
                    str += " Lucky\n";
                }
                else
                    str += " Unlucky\n";
            }
            return str;
        }
    }
}
