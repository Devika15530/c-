using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 d array");
            /*int[,] marks = new int[3, 3];
            for(int i=0;i<3;i++)
            {
                for(int  j=0;j<3;j++)
                {
                    marks[i,j] = int.Parse(Console.ReadLine());
                   
                    
                }
                Console.WriteLine("row completed");
            }

            Console.WriteLine("entered elements");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(marks[i, j]+" " ); 
                }
            }
            Console.WriteLine(" \n");
            int largest = 0;
            for (int j=0;j<3;j++)
            {

                for (int i = 0; i < 3; i++)
                {

                    if (marks[ i,j] > largest)
                    {
                        largest = marks[j, i];
                    }
                }
                Console.WriteLine("highest score of each subject is:"+largest);
            }*/


            Console.WriteLine("jagged array");
            string[][] names = new string[3][];
             for(int i=0;i<3;i++)
            {
                Console.WriteLine("enter size"+(i+1));
                int size = int.Parse(Console.ReadLine());
                names[i] = new string[size];
            }

            Console.WriteLine("enter names");
            for(int row=0;row<3;row++)
            {
                for(int col=0;col<names[row].Length;col++)
                {
                    names[row][col] = Console.ReadLine();
                }
                Console.WriteLine("row completed");
            }
            Console.WriteLine("array elements are");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < names[row].Length; col++)
                {
                    Console.Write(" " + names[row][col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("using foreach to print");
            foreach (string s in names[1])
                Console.Write(s);



            Console.ReadKey();
        }
    }
}
