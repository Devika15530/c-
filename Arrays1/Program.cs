using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main()
        {
            /* int[] a = new int[4];
             for (int i = 0; i < 4; i++)
             {
                 Console.Write("enter a[{0}]:", i);
                 a[i] = int.Parse(Console.ReadLine());
             }
             foreach (int k in a)
                 Console.WriteLine(k);*/
            int l = int.Parse(Console.ReadLine());
            string[] names = new string[l];

            for (int i = 0; i < l; i++)
            {
                Console.Write("enter a[{0}]:", i);
                names[i] = Console.ReadLine();
            }
            foreach (string k in names)
                Console.WriteLine(k);
            Console.WriteLine("enter name");

            string m =Console.ReadLine();
            int flag = 0;
            for(int i=0;i<l;i++)
            {
                
                     if (names[i] == m)
                    {
                    flag = 1;
                        Console.WriteLine("name" + names[i] + "index is " + i);

                    break;
                    }
                
                
               

            }
            if(flag==0)
                Console.WriteLine("does not exist");


            Console.ReadKey();















            
        }
    }
}
