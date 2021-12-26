// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8


Console.WriteLine("введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int minNumber = 8;

int[] array = new int[n];
for (int i = 1; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int[] arrayNew = array;
for (int j = 0; j < arrayNew.Length; j++)
{
    if (arrayNew[j] > minNumber)
    {
        Console.Write(arrayNew[j] + " ");
    }
}