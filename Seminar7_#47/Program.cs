// Задача 41. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//***********************
bool InputDannyh(string text, out int val1, out int val2)
{
    val1 = 0;
    val2 = 0;
    Console.Write($"{text} через пробел: ");
    int[] array = Console.ReadLine().Split(' ', 2, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    if (array.Length < 2)
    {
        Console.WriteLine("Вводимые данные должны состоять из 2х чисел, разделенных пробелом!!!");
        Console.Write("Хотите повторно ввести данные? (y - да): ");
        string otvet = Console.ReadLine();
        if (otvet == "y" || otvet == "Y")
        { return InputDannyh(text, out val1, out val2); }
        
        return false;
    }
    val1 = array[0];
    val2 = array[1];
    return true;
}

//************************
void InputArray(double[,] arr, int minR, int maxR)
{
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(minR + rnd.NextDouble() * (maxR - minR),2);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//***********************
Console.Write("Программа задает двумерный массив размером [m,n], заполненный случайными вещественными числами.");
Console.WriteLine("");

int m, n, minR, maxR;

if (!InputDannyh("Введите размерность массива [m,n]", out m, out n) || !InputDannyh("Введите диапазон начала и конца заполнения массива, НЕравные по модулю,", out minR, out maxR))
{ Console.WriteLine("Расчет прерван из-за отказа ввода данных"); }
else
{
    double[,] array = new double[m, n];
    InputArray(array, minR, maxR);
}


