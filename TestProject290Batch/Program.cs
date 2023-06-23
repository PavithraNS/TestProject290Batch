using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject290Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TestProject");
            ArrayConcepts arrayConcepts = new ArrayConcepts();
            Console.WriteLine("Please enter how many elements you want to store it in array");
            int size = Convert.ToInt32(Console.ReadLine());
            arrayConcepts.ArrayCreation(size);
            arrayConcepts.DisplayArrayElements();
            Console.ReadLine();
        }
    }
}
