internal class Program
{
    private static void Main(string[] args)
    {
        void Main()
        {

            int[] numbers = new int[10];
            Random rand = new Random();
            int chet = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(100, 1000);
                System.Console.WriteLine(numbers[i]);

                if (numbers[i] % 2 == 0)
                {
                    chet++;
                }


            }

            System.Console.WriteLine($"{chet}" + " четных чисел в массиве");






        }

        Main();
    }
}