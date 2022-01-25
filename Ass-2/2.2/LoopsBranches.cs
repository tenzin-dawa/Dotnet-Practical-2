using System;
namespace LoopsBranches
{
    class LoopBr {
        public static void Ifsmt()
        {
            Console.WriteLine("\nMAKING DECISIONS USING THE IF STATEMENT...");
            int a = 5;
            int b = 6;
            if (a + b > 10)
            Console.WriteLine("Answer is greater than 10.");
            int c = 5;
            int d = 3;
            if (c + d > 10)
            Console.WriteLine("Answer is greater than 10.");
        }
        public static void Ifelsesmt()
        {
            Console.WriteLine("\nMAKING DECISION USING IF & ELSE ...");
            int a = 5;
            int b = 3;
            int c = 4;
            if (a + b > 10)
                Console.WriteLine("Answer is greater than 10.");
            else
                Console.WriteLine("Answer is not greater than 10.");
            if (a + b > 10)
            {
                Console.WriteLine("Answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("Answer is not greater than 10.");
            }
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("Answer is greater than 10.");
                Console.WriteLine("And the first number is equal to the second number.");
            }
            else
            {
                Console.WriteLine("Answer is not greater than 10.");
                Console.WriteLine("Or the first number is not equal to the second number.");
            }
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("Answer is greater than 10.");
                Console.WriteLine("Or the first number is equal to the second number.");
            }
            else
            {
                Console.WriteLine("Answer is not greater than 10.");
                Console.WriteLine("And the first number is not equal to the second number.");
            }
        }
        public static void loopsRec()
        {
            Console.WriteLine("\nUSING LOOPS TO REPEAT OPERATIONS...");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"[While Loop] HI COUNTER : {counter}");
                counter++;
            }
            int cnter = 0;
            do
            {
                Console.WriteLine($"[Do While Loop] HI COUNTER : {cnter}");
                cnter++;
            } while (cnter < 10);
        }
        public static void forLoop()
        {
            Console.WriteLine("\nWORKING WITH FOR LOOP...");
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"[For Loop] HI COUNTER : {counter}");
            }
        }
        public static void Nestloops()
        {
            Console.WriteLine("\nCREATING NESTED LOOPS...");
            for (int row = 1; row < 11; row++)
            {
                Console.WriteLine($"rows is {row}");
            }
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"column is {column}");
            }
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"[RowxColumn]= ({row}, {column})");
                }
            }
        }
        public static void BrLoop()
        {
            Console.WriteLine("\nCOMBINATION OF BRANCHES WITH LOOPS...");
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"SUM is= {sum}");
        }
    }
}