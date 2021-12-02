using System;
using System.IO;
using System.Linq;

namespace day02
{
    enum Directions { up, down, forward }
    class Instruction
    {
        public Directions Direction { get; set; }
        public int Distance { get; set; }

        public Instruction(string Dir, int Dis)
        {
            switch (Dir)
            {
                case "up":
                    Direction = Directions.up;
                    break;
                case "down":
                    Direction = Directions.down;
                    break;
                case "forward":
                    Direction = Directions.forward;
                    break;
                default:
                    break;
            }

            Distance = Dis;
        }

        class day2sub
        {
            public int Horizontal { get; set; }
            public int Vertical { get; set; }

            public day2sub()
            {
                Horizontal = 0;
                Vertical = 0;
            }

            public void Move(Instruction ins)
            {
                if (ins.Direction == Directions.forward)
                {
                    Horizontal += ins.Distance;
                    return;
                }

                switch (ins.Direction)
                {
                    case Directions.up:
                        Vertical -= ins.Distance;
                        break;
                    case Directions.down:
                        Vertical += ins.Distance;
                        break;
                    default:
                        break;
                }
            }

            public int Pt1()
            {
                return Horizontal * Vertical;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                // pt 1
                var input = File.ReadAllLines(args[0]).ToList();
                var pt1Sub = new day2sub();

                foreach (string line in input)
                {
                    var components = line.Split(" ");
                    var ins = new Instruction(components[0], int.Parse(components[1]));
                    pt1Sub.Move(ins);
                }

                Console.WriteLine($"Pt1: {pt1Sub.Pt1()}");
            }
        }
    }
}