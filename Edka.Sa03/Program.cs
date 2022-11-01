using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Fonte de dados(Vetor, Matrix Collections, .xls, .xml, .txt, .csv, .sql)

            int[] votos = new int[10]
            {

              1,2,3,4,5,6,7,8,9,10



            };
            //2. Consulta: Query Sintaxe. Linq

            var consulta = from voto in votos
                           select votos;

            //3. Executando Consulta

            foreach (int voto in votos)
            {
                Console.WriteLine(votos[voto]);

            }
            Console.WriteLine();   

        
        }
    }
}
