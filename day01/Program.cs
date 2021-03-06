using System;
using System.IO;
using System.Linq;

namespace day01
{
    class Program
    {
        static void Main(string[] args)
        {
            // pt 1
            var input = File.ReadAllLines(args[0]).Select(int.Parse).ToArray();
            var pt1 = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > input[i - 1]) pt1++;
            }

            Console.WriteLine($"Part 1: {pt1}");

            // pt 2
            var pt2 = 0;

            for (int i = 3; i < input.Length; i++)
            {
                if (input[i] > input[i - 3]) pt2++;
            }

            Console.WriteLine($"Part 2: {pt2}");
        }
    }
}
