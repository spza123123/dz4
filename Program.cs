using System;

void Main()
{

    while (true)
    {
        Console.Write("Введите число: ");
        string Enter = Console.ReadLine();
        if (Enter == "q")
        {
            break;

        }
        int num;
        if (int.TryParse(Enter, out num))
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 2 == 0)
            {
                System.Console.WriteLine("STOP");
                break;
            }

        }
        else
        {
            System.Console.WriteLine("Try again");
        }







    }




}

Main();