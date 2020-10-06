using Microsoft.VisualBasic;
using System;

namespace Do_While_LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            //base number array
            int i = 0;
            //counter


            //while (i < nums.Length)
           // {
                //Console.WriteLine("|" + i++ + "|");
           // }

            while ( i < nums.Length)
            {
                nums[i] = i; // I think it's saying that the index position for nums here is 0, since the integer type variable i is in fact, assigned to the value of zero
                Console.Write("|" + nums[i] + "|");
                i++;
            }
            Console.Write("\n \n");

            do
            {
                i--;

                Console.Write("|" + i + "|");
            }




            while (i > 0);

            Console.WriteLine("\n");


            // My own custom example 

            int[] century = new int[2021];
            int year = 1;


            while( year < century.Length )
            {
                century[year] = year;
                year++;
                Console.WriteLine("Year:" + year + "AD");
                if (year == 1914) { Console.Write("This is the year Europe blew up!" + "\n");
                    continue;
                }
                if (year == 2021) { Console.Write("And there we have it!");
                    break;
                }
                if (year == 476) { Console.Write("This is the year the civilized world went oof." + "\n"); }

            }
            Console.ReadKey();
        
        
        }
    }
}
