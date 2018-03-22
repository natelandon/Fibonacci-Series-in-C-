using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, add = 1, i = 0, j = 1;
            Console.Write("Please Enter the Maximum Limit : ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i);

            while (add <= max)
            {
                Console.WriteLine(add);
                add = i + j;
                i = j;
                j = add;
            }
        }
    }
}
