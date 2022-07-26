using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1 Write a C# Sharp program to check two given integers, 
            and return true if one of them is 30 or if their sum is 30. 
             */
            //---------------------------------------------------------
            Console.WriteLine("Enter Number1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum = n1 + n2;
            Console.WriteLine("Sum of the Numbers is : " +sum);
            if (n1 == 30 || n2 == 30 || n1 + n2 == 30)
                Console.WriteLine("TRUE");
            else
                Console.WriteLine("FALSE");
            //----------------------------------------------------------------------------------

            /*
             * 2 Write a C# Sharp program to check if a given positive number is a multiple of 3 
             */
            //or a multiple of 7
            //---------------------------------------------------------
            //Console.WriteLine("Enter Number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n % 3 == 0 & n % 7 == 0)
            //    Console.WriteLine("Number is divisible by 3 & 7");
            //else if (n % 3 == 0)
            //    Console.WriteLine("Number is divisible by 3");
            //else if (n % 7 == 0)
            //    Console.WriteLine("Number is divisible by 7");
            //else
            //    Console.WriteLine("Number is not divisible by 3 & 7");
            //----------------------------------------------------------------------------------

            /*
             * 3 Write a program in C# Sharp to display the first 10 natural numbers
             */
            //---------------------------------------------------------
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);// Natural Nos = 1 To Infinity
            //}
            //----------------------------------------------------------------------------------

            /*
             * 4 Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average
             */
            //---------------------------------------------------------
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Enter Number{0}: ", i);
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    sum += n;
            //}
            //Console.WriteLine("Sum of All Numbers = {0}", sum);
            //Console.WriteLine("Avg of All Numbers = {0}", sum / 10);
            //----------------------------------------------------------------------------------

            /*
             * 5 Write a program in C# Sharp to display the cube of the number up to given an integeR
             */
            //---------------------------------------------------------
            //Console.WriteLine("Enter Number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1, cube = 1; i <= n; i++)
            //{
            //    cube = i * i * i;
            //        Console.WriteLine("Cube of {0} : {1} ", i, cube);
            //}
            //----------------------------------------------------------------------------------

            /*
             6 Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk. 
                The pattern like :
                *
                **
                ***
                ****
             */
            //---------------------------------------------------------
            //Console.WriteLine("Enter Number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            //----------------------------------------------------------------------------------
            /*
             7  Write a program in C# Sharp to display the pattern like right angle triangle with a number. 
                The pattern like :
                1
                12
                123
                1234
             */
            //---------------------------------------------------------

            //Console.WriteLine("Enter Number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0} ",j);
            //    }
            //    Console.WriteLine();
            //}
            //----------------------------------------------------------------------------------

            /*
             8
                Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row. 
                The pattern like :
                1
                22
                333
                4444
             */
            //---------------------------------------------------------
            //Console.WriteLine("Enter Number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0} ", i);
            //    }
            //    Console.WriteLine();
            //}
            //----------------------------------------------------------------------------------

            /*
             9
                Write a program in C# Sharp to make such a pattern like right angle triangle 
                with number increased by 1
                The pattern like :
                1
                2 3
                4 5 6
                7 8 9 10 
             */
            //---------------------------------------------------------
            //Console.WriteLine("Enter Number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0} ", count++);
            //    }
            //    Console.WriteLine();
            //}
            //----------------------------------------------------------------------------------
        }
    }
}
