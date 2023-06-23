using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject290Batch
{
    class ArrayConcepts
    {
       public int[] arr;

        public void ArrayCreation(int size)//5
        {
            arr = new int[size];
            Console.WriteLine("Start entering {0} elements one by one",size);
            for(int i=0;i<size;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());//"10"
            }
        }

        public void DisplayArrayElements()
        {
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
        }
    }
}
