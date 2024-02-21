using System.Globalization;

internal partial class Program
{
    private static void Main(string[] args)
    {
        void Main()
        {

            int[] array = [1, 4, 5, 6, 2];
            int temp;
            System.Console.WriteLine("Исходный массив ");
            foreach(int number in array)
            {
                System.Console.Write(number + " ");
            }

            for (int i = 0; i < array.Length /2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;

            
            
            }

            System.Console.WriteLine("Перевернутый массив ");

            foreach(int number in array)
            
             Console.Write(number + " ");








        }

        Main();
    }
}