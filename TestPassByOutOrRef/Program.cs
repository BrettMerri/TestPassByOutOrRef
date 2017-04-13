using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPassByOutOrRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input = 3;
            int S, C;

            S = ReturnCubeSquare(Input, out C);

            Console.WriteLine(S + "\n" + C);
        }

        public static int ReturnCubeSquare(int number, out int ReturnedCube)
        {
            int Square = number * number;
            int Cube = number * number * number;

            ReturnedCube = Cube; //return value of the cube back to the main
            return Square;
        }
    }
}
