using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fourth Pattern Program
namespace FirstDemo
{
    internal class FourthPatternProgram
    {
        static void Main(string[] args)
        {
            int rows = 7;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
