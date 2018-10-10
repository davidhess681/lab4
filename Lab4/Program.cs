using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            do
            {
                // Get user input
                Console.WriteLine("Learn your squares and cubes!");
                Console.Write("Enter an integer:");
                int userNum = int.Parse(Console.ReadLine());

                // Start the table
                Console.WriteLine("");
                Console.WriteLine("Number       Squared       Cubed");
                Console.WriteLine("======       =======       =====");

                // Loop the statement for each int before userNum
                for (int i = 1; i <= userNum; i++)
                {
                    // Calculate square and cube 
                    int squ = i * i;
                    int cube = i * i * i;

                    // Determine how many spaces to put between numbers so the table aligns correctly
                    if (i < 4)
                    {
                        Console.WriteLine("{0}            {1}             {2}", i, squ, cube);
                    }
                    else if (i >= 4 && i < 10)
                    {
                        Console.WriteLine("{0}            {1}            {2}", i, squ, cube);
                    }
                    else if (i >= 10 && i < 32)
                    {
                        Console.WriteLine("{0}           {1}           {2}", i, squ, cube);
                    }
                    else if (i >= 32 && i < 100)
                    {
                        Console.WriteLine("{0}           {1}          {2}", i, squ, cube);
                    }
                    else if (i >= 100 && i < 317)
                    {
                        Console.WriteLine("{0}          {1}         {2}", i, squ, cube);
                    }
                    // At this high a number any alignment errors won't matter
                    else
                    {
                        Console.WriteLine("{0}          {1}        {2}", i, squ, cube);
                    }

                }
                Console.WriteLine("");

                // Close program per user request
                Console.WriteLine("Continue? (y/n)");
                if (Console.ReadLine() == "n")
                {
                    cont = false;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            while (cont);
        }
    }
}
