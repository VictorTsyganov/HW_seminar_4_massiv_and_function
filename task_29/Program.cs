// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine($"Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int [size];

NewMass(arr);
Console.Write(ReadMass(arr));

void NewMass(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

string ReadMass(int[] array)
{
    string text = $"[{array[0].ToString()}";
    for (int i = 1; i < array.Length; i++)
    {
        text = $"{text}, {array[i].ToString()}";
    }
    return text + "]";
}