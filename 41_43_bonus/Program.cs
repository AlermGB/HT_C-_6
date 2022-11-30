// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Дополнительная задача на рекурсию (необязательная)
// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

Console.WriteLine("");
Console.WriteLine("Приветствую вас, Алексей! Введите номер задачи из домашнего задания для проверки(41, 43 или 0(дополнительное задание))");

int taskNumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("");

//Первая задача (41)
if (taskNumber == 41)
{

    Console.WriteLine("Задача 41.");
    Console.WriteLine();

    Console.Write("Введите M положительное целочисленное значение количества анализируемых чисел: ");
    int M = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("");
    int counter = 0;
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            counter++;
        }
    }
    Console.Write("Среди введённых вами чисел: ");
    Console.Write('[' + string.Join(", ", array) + ']');
    Console.Write(" " + counter + " положительных");
    Console.WriteLine();

}

//Вторая задача (43)
else if (taskNumber == 43)
{

    Console.WriteLine("Задача 43.");
    Console.WriteLine();

    Console.WriteLine("Введите коэффициенты соответствующие уравнениям для двух прямых: ");
    Console.Write("Первая прямая y = k1 * x + b1; k1 = ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b1 = ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Вторая прямая y = k2 * x + b2; k2 = ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b2 = ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine();

    if (k1 == k2 && b1 != b2)
    {
        Console.Write("Прямые параллельны, точек пересечения нет! ");
    }
    else if (k1 == k2 && b1 == b2)
    {
        Console.Write("Прямые совпадают! ");
    }
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения ваших прямых: ({x}; {y})");
    }
    Console.WriteLine();

}

//Третья задача (Дополнительная задача)
else if (taskNumber == 0)
{
    Console.WriteLine("<!!Бонусное задание!!>");
    Console.WriteLine();

    int DigitNumber(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        return DigitNumber(number / 10) + 1;
    }

    Console.WriteLine("Введите число");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine();
    Console.WriteLine(DigitNumber(number));
}

else
{
    Console.WriteLine("Увы, в этом блоке представлено только три задачи: 41, 43 и дополнительное задание с индексом 0");
}

Console.WriteLine();
Console.WriteLine("Всего доброго.");
Console.WriteLine();