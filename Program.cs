﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicjalnoPonavljanjeZadatak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url;

            Console.WriteLine("Upišite URL adresu:");
            url = Console.ReadLine();

            if (url.StartsWith("www.") && url.EndsWith(".hr"))
            {
                Console.WriteLine("URL je pravilan.");
            }
            else
            {
                Console.WriteLine("URL nije pravilan.");
            }

            Console.ReadKey();
        }
    }
}
