int InputInt(string? value)                                               // Проверка что ввели целое число;
{
    int number = 0;
    while (!int.TryParse(value, out number))
    {
        Console.Write("Не подходит к требованию введите число: ");
        value = Console.ReadLine();
    }
    return number;
}
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine($"Задача 25. Возведение числа A в натуральную степень B");
// int numberA = 1;
// int numberB = 1;

// void Number(ref int numberA, ref int numberB)                             // Ввод чисел A и B и проверяем натуральное ли число B
// {
//     Console.Write("Введите число A: ");
//     numberA = InputInt(Console.ReadLine());
//     Console.Write("Введите число B: ");
//     numberB = InputInt(Console.ReadLine());
//     if (numberB < 0)
//     {
//         Console.Write("Введите число B: ");
//         numberB = InputInt(Console.ReadLine());
//     }
// }

// int Exponentiation(int numberA, int numberB)                              // Возводим число A в степень числа B или можно просто в Math.Pow
// {
//     int result = 1;
//     for (int i = 1; i <= numberB; i++)
//     {
//         result = result * numberA;
//     }
//     return result;
// }

// Number(ref numberA, ref numberB);                                         // Получаем числа
// Console.WriteLine($"Ответ: {Exponentiation(numberA, numberB)}");          // и ответ

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine($"Задача 27. Выдаёт сумму цифр в числе");
Console.Write("Введите число N: ");
int numberN = InputInt(Console.ReadLine());

int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;                         // узнаем количество цифр в числе
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;                                   // обнуляем последнею цифру в числе
        result = result + (numberN - advance);                              // сумма последних цифр, поэтому будет работать и с отрицательными числами
        numberN = numberN / 10;                                             // уменьшаем число на один знак
    }
    return result;                                                          // конечная сумма всех чисел
}

Console.WriteLine($"Сумма цифр в числе: {SumNumber(numberN)}");