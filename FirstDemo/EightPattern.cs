using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8th Pattern program
namespace FirstDemo
{
    internal class EightPattern
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i = 0;i<n; i++)
            {
                for(int j=0;j<n; j++)
                {
                    if((i+j)%2 == 0)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
