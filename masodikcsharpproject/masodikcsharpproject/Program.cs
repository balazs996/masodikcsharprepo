using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikcsharpproject
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("1-től 100-ig azok a számok melyek valódi osztóinak összege osztható 7-el");
             for (int i = 1; i < 101; i++)
             {
                 if (sumSeven(i))
                 {
                     Console.WriteLine($"{i} valódi osztóinak száma osztható 7-tel.");
                 }            
             }*/
            Console.WriteLine("2-től 100-ig");

            for (int i = 2; i < 101; i++)
            {
                if (primszamE(i))
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadKey(true);
            
        }

        static bool sumSeven(int num)
        {
            int sum = 0;
            bool wSeven = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            if (sum % 7 != 0)
            {
                wSeven = false;
            }

            return wSeven;
        }    

        static bool primszamE(int num)
        {
            bool primE = true;
            int hatar = (int)Math.Floor(Math.Sqrt(num)) + 1;

            for (int i = 2; i < hatar; i++)
            {
                if (num % i == 0)
                {
                    primE = false;
                    break;
                }
            }

            return primE;





        }









    }
}
