// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "baba", "fortunate", "deolu", "shakirat" };
            
            foreach( string name in names)

            {
                
                Console.WriteLine(name[name.Length-1].ToString().ToUpper());
            }
        }
    }
}