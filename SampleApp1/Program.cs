using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp1
{
    class Program
    {
        static void print()
            {
                Console.WriteLine("From method print changes");
            }
        static void Main(string[] args)
        {
            print();
        }
    }
}
