using System;
using System.IO;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../nums.txt";
           
            using (StreamReader reader = new StreamReader(path))
            {
                string numbers = reader.ReadToEnd();
                
                
                using (StreamWriter writer = new StreamWriter(path))
                {
                    int[] nums = numbers.Split(' ').Select(int.Parse).ToArray();
                    
                    foreach (int i in nums)
                    {
                        if (i % 2 != 0)
                        {
                            writer.Write(i + " ");
                        }
                    }
                }
            }
        }
    }
}
