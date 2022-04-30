using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            testFunc2();
        }

        private static void testFunc2()
        {
            Random random = new Random();
            double[] randomDoubles = new double[20];

            for (int i = 0; i < 20; i++)
            {
                randomDoubles[i] = random.NextDouble();
            }

            int count = 0;
            foreach (var item in randomDoubles)
            {
                Console.Write($"# {++count} = ");
                Console.WriteLine(item);
            }
        }

        private static void testFunc()
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
