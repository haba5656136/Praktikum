// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8


Console.WriteLine("введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int [] array = new int[n];

for (int i = 1; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
    Console.WriteLine(array[i] + " ");
}