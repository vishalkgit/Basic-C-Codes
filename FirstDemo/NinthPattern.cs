using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ababab 9th pattern
namespace FirstDemo
{
    internal class NinthPattern
    {
        static void Main(string[] args)
        {
            int n = 6;
            for(int i=1; i<=n; i++)
            {
               for(int j=i; j<n; j++)
                {
                    Console.Write(" ");
                }
               for(int k=1; k<=i;k++)
                {
                   if(k%2==0)
                    {
                        Console.Write("b ");
                    }
                   else
                    {
                        Console.Write("a ");
                    }
                }
                Console.WriteLine();
            }
            

            
        }
    }
}
