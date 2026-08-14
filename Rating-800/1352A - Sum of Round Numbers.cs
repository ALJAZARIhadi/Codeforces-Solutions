using System;

public class Program
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int number = int.Parse(Console.ReadLine());

            int count = 0;
            int place = 1;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;

                if (digit != 0)
                {
                    count++;
                }

                temp /= 10;
                place *= 10;
            }

            Console.Write(count);

            temp = number;
            place = 1;

            while (temp > 0)
            {
                int digit = temp % 10;

                if (digit != 0)
                {
                    Console.Write(" " + (digit * place));
                }

                temp /= 10;
                place *= 10;
            }

            Console.WriteLine();
        }
    }
}
