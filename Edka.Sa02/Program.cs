﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //18 29 37 48 17 16 54 72 45 30    

            int[] idades = new int[10]
            {
                18,29,37,48,17,16,54,72,45,30
            };
            double soma = 0;
           double media = 0;      
            
            for(int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine(idades[i]);
                soma = idades[i];
            }
            media = soma/10 ;
            Console.WriteLine("A media e:" +media);
            Console.ReadKey();  
    
        }
    }
}
