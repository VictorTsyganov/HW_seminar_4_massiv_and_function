// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.WriteLine($"Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите второе (натуральное) число: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {num1} в степени {num2} равно {Exponentiation(num1, num2)}");

int Exponentiation(int number1, int number2)
{
    int exp = number1;
    for (int i = 1; i < number2; i++)
    {
        exp = exp * number1;
    }
    return exp;
}
