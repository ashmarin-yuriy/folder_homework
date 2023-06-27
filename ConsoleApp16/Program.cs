/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * new Random().Next(0, 10), 2);
    Console.WriteLine(array[i] + "  ");
}

double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array [i] < min)
    {
        min = array [i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
