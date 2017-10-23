using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_excuses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] excuses = new[] { "koer sõi", "Ema ei luba arvutit", " lammas all nurgas" };
            
            for (int i = 0; i < excuses.Length; i++)
            { 
                Console.WriteLine($"{i + 1}. {excuses[i]}");
            }
            Console.ReadLine();
        }
    }
}
