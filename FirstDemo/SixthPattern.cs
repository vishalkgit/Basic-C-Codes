﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sixth Pattern Program
namespace FirstDemo
{
    internal class SixthPattern
    {
        static void Main(string[] args)
        {
            int rows = 5;
            for(int i=1;i<=rows;i++)
                {
                for(int j=1;j<=i;j++)
                { 
                    Console.Write("*");
                }
                 Console.WriteLine();
            }
                    for(int i=rows;i>=1;i--)
                    {
                        for(int j=1;j<=i;j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();

                    }
        }
    }
}
