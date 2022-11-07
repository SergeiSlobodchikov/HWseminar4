int InputInt(string? value)                                             //Проверка что ввели число и целое оно;
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
Console.WriteLine($"Задача 25. Возведение числа A в натуральную степень B");
int numberA = 1;
int numberB = 1;

void Number(ref int numberA, ref int numberB)                             // Ввод чисел A и B и проверяем натуральное ли число B
{
    Console.Write("Введите число A: ");
    numberA = InputInt(Console.ReadLine());
    Console.Write("Введите число B: ");
    numberB = InputInt(Console.ReadLine());
    if (numberB < 0)
    {
        Console.Write("Введите число B: ");
        numberB = InputInt(Console.ReadLine());
    }
}

int Exponentiation(int numberA, int numberB)                            // Возводим число A в степень числа B
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Number(ref numberA, ref numberB);                                   
Console.WriteLine($"Ответ: {Exponentiation(numberA, numberB)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12