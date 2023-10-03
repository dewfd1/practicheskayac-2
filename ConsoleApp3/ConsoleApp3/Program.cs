using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Меню:");
        Console.WriteLine("1. Игра 'Угадай число'");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");
        Console.WriteLine("0. Выход");
        Console.WriteLine();

        while (true)
        {
         
            Console.Write("Введите число для выбора программы: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    GuessNumberGame();
                    break;
                case 2:
                    MultiplicationTable();
                    break;
                case 3:
                    PrintDivisors();
                    break;
                case 0:
                    Console.WriteLine("Выход из программы");
                    return;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void GuessNumberGame()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 100);

        Console.WriteLine("Игра 'Угадай число'");
        Console.WriteLine("Я загадал число от 0 до 100.");
        Console.WriteLine("Попробуйте угадать!");

        int attempts = 0;
        while (true)
        {
            Console.Write("Введите число: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess == randomNumber)
            {
                Console.WriteLine($"Поздравляю! Вы угадали число с {attempts} попытки.");
                break;
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine("Загаданное число не больше, чем 100.");
            }
        }
    }

    static void MultiplicationTable()
    {
        int[,] table = new int[10, 10];

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                table[i - 1, j - 1] = i * j;
            }
        }

        Console.WriteLine("Таблица умножения:");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{table[i - 1, j - 1]}\t");
            }
            Console.WriteLine();
        }
    }

    static void PrintDivisors()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Делители числа {number}:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
