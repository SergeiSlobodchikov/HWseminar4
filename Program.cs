 int InputInt(string? value)                                       //проверка ввел ли число
{
    int number = 0;
    while (!int.TryParse(value, out number))
    {
        Console.Write("Не подходит к требованиЮ введите число: ");
        value = Console.ReadLine();
    }
    return number;
}
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine($"Задача 25. Возведение числа A в натуральную степень B");

int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = InputInt(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = InputInt(Console.ReadLine());
  if(numberB<0)
    {   
        Console.Write("Введите число B: ");
        numberB = InputInt(Console.ReadLine());
    }

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12