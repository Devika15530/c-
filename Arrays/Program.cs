using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int[] i = new int[4];
            i[0] = 12;
            i[1] = 13;
            i[2] = 14;
            i[3] = 11;
            int k = i[2];
            Console.WriteLine(k);
            for(int a=0;a<=3;a++)
             {
                 Console.WriteLine(i[a]);
             }
            foreach (int no in i)
            {
                Console.WriteLine(no);
            }

            Console.ReadKey();*/

        }

        class Demo1
        {
            static void main()
            {
                int[] b = new int[4] { 11, 12, 13, 14 };
                foreach (int i in b)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

    }
}