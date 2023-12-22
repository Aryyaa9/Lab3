using System;
using System.IO;
using System.Linq;

namespace ConsoleApplication1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../File.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string nums = reader.ReadLine();
                int[] height = nums.Split(' ').Select(int.Parse).ToArray();
                int i = height.Length;

                int max = 0;

                for (int j = 0;   j < i - 1;   j++)   // перебор индекса 1-го столбца
                {
                    for (int k = j + 1;   k < i;   k++)   // перебор инд 2 столбца
                    {
                        int square = Math.Min(height[j], height[k]) * (k - j);
                        if (square > max)
                            max = square;
                    }
                }
                Console.WriteLine(max);
            }
        }
    }
}