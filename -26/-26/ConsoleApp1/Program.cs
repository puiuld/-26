using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] omas=Input();

            Output(omas);
            Console.ReadLine();
        }
        static int[] Input()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] omas = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"omas[{i}]=");
                omas[i] = int.Parse(Console.ReadLine());
            }
            return omas;

        }
        
        static void Output(int[] omas) 
        { 
        
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }
    
    }
}
