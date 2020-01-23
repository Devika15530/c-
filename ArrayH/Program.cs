using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayH
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x=int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("enter odd size");
            }
            else
                Console.WriteLine("size o array"+ x);
f
            int[] num = new int[x];
            Console.WriteLine("enter elements into the array");
            for(int i=0;i<x;i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int first = num[0];
            int y = x / 2;
            int middle = num[y];
            int last = num[x - 1];
            if (first > middle && first > last)
            {
                Console.WriteLine("largest is" + first);
            }
            else if (middle > last)
                Console.WriteLine("largest is" + middle);
            else
                Console.WriteLine("largest is" + last);
            */

            int[][] num = new int[2][];
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("size");
                int size = int.Parse(Console.ReadLine());
                num[i] = new int[size];
            }
            Console.WriteLine("enter array elements");
            for(int row=0;row<2;row++)
            {
                for(int col=0;col<num[row].Length;col++)
                {
                    num[row][col] = int.Parse(Console.ReadLine());
                   
                }
                Console.WriteLine("row completed");
            }
            int x=0,sum=0;
            for (int i = 0; i < 2; i++)
            {
                
                for (int j = 0; j < num[i].Length; j++)
                {
                  x=num[i][j];
                    for (int k = 1; k < num[i].Length; k++)
                    {
                        if (k == j)
                            break;



                       else
                        {
                            if(x == num[i][k])


                            sum=sum+x+num[i][k];
                            
                        }
                    }
                }
            }

            if (sum != 0)
                Console.WriteLine(sum);
            else
                Console.WriteLine("no common elements");


            Console.ReadKey();
        }
    }
}
