// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8


Console.WriteLine("введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());//введение с клавиатуры размерности массива
int minNumber = 8;

int[] array = new int[n];//массив размерностью n
for (int i = 1; i < array.Length; i++)//заполнение массива рандомными числами от 1 до 100
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + " ");//вывод на экран каждого элемента массива в строку
}
Console.WriteLine();//переходна новую строку

int[] arrayNew = array;//создание нового массива для заполнения числами которые больше 8
for (int j = 0; j < arrayNew.Length; j++)
{
    if (arrayNew[j] > minNumber)
    {
        Console.Write(arrayNew[j] + " ");
    }
}