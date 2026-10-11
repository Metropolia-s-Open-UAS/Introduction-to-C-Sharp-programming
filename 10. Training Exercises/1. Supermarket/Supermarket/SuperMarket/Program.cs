using System;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] productPrice = new int[10] { 10, 14, 22, 33, 44, 13, 22, 55, 66, 77 };

            int productNumber;
            int sum = 0;
            Console.WriteLine("Supermarket");
            Console.WriteLine("===========");
            while (true)
            {
                Console.Write("Please select product (1-10) 0 to Quit:");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out productNumber))
                {
                    Console.WriteLine("Please enter a number");
                    continue;
                }

                if (productNumber == 0)
                {
                    break;
                }
                else if (productNumber < 0 || productNumber > 10)
                {
                    Console.WriteLine("Please select correct product (1-10)");
                }
                else
                {
                    Console.WriteLine("Product: " + productNumber + " Price: " + productPrice[productNumber - 1]);
                    sum += productPrice[productNumber - 1];
                }
            }

            Console.WriteLine("Total: " + sum);

            int payment;
            while (true)
            {
                Console.Write("Payment: ");
                if (int.TryParse(Console.ReadLine(), out payment))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid amount");
            }

            if (payment < sum)
            {
                Console.WriteLine("Not Enough Money");
            }
            else
            {
                Console.WriteLine("Change: " + (payment - sum));
            }
        }
    }
}