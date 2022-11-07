// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();

Console.WriteLine($"Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {num} равна {SummDigits(num)}");

int SummDigits(int number)
{
    int summ = 0;
    int digit = 0;
    while(number > 0)
    {
        digit = number % 10;
        number = number / 10;
        summ = summ + digit;
    }
    return summ;
}