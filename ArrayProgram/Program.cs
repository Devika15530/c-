using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("enter numbers");
            for (int i=0;i<n;i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("enter numbers are");
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }

            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if(numbers[i]<numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }



            }
            Console.WriteLine("after swapping array");
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("smallest is"+numbers[0]);
            Console.WriteLine("largest is"+numbers[n-1]);



            Console.ReadKey();


        }
       

    }
}
