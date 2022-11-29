// Задайте массив вещественных чисел, найдите разницу между максимальным и минимальным элементом массива.

int size = ReadInt("Введите размер массива: ");
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers, 0, 10);
WriteArray(numbers);

double max = numbers[0];
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > max) max = numbers[i];
}
Console.WriteLine($"Максимальный элемент: {max}");

double min = numbers[0];
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] < min) min = numbers[i];
}
Console.WriteLine($"Минимальный элемент: {min}");

double result = max - min;
Console.WriteLine($"Разница: {result}");

void FillArrayRandomNumbers(double[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max) + new Random().NextDouble();
    }
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ";" + " ");
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
