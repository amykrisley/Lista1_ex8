﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c;
            double f;

            Console.Write("Informe o valor em °c: ");
            c = double.Parse(Console.ReadLine());

            f = ((c / 5) * 9) + 32;

            Console.WriteLine("o valor em °f é = {0}", f);

        }
    }
}
