//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


        int count = GetCountFromUser();
        int positiveCount = CountPositiveNumbers(count);
        PrintResult(positiveCount);


     int GetCountFromUser()
    {
        Console.Write("Введите количество чисел, которые вы хотите ввести: ");
        return int.Parse(Console.ReadLine()!);
    }

    int CountPositiveNumbers(int count)
    {
        int positiveCount = 0;

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            int number = int.Parse(Console.ReadLine()!);

            if (number > 0)
            {
                positiveCount++;
            }
        }

        return positiveCount;
    }

    static void PrintResult(int positiveCount)
    {
        Console.WriteLine($"Количество чисел больше 0: {positiveCount}");
    }
