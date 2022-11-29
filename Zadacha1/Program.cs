// Задайте массив, заполненный случайными положительными трехзначными цифрами.
// Напишите программу, которая покажет количество четных чисел в массиве

int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, 100, 1000);
WriteArray(numbers);

int count = 0;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]%2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {count}");

void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}