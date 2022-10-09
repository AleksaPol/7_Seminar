
void Zadacha47()
{
    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
    // вещественными числами, округлёнными до одного знака.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9

    Console.WriteLine("Задача 47.");
    Console.WriteLine("Сколько строк будет в массиве?");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сколько столбцов будет в массиве?");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"Массив размера {rows}*{columns}:");
    Console.WriteLine();
    double[,] numbers = new double[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

}
void FillArray(double[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round(random.NextDouble(), 1) + random.Next(-100, 100);
        }
    }
}
void PrintArray(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
Zadacha47();


void Zadacha50()
{
    // Задача 50. Напишите программу, которая на вход принимает 
    // индексы элемента в двумерном массиве, и возвращает значение 
    // этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 17 -> такого числа в массиве нет
    Console.WriteLine("______________________________________");
    Console.WriteLine("Задача 50.");
    Console.WriteLine("Сколько строк будет в массиве?");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сколько столбцов будет в массиве?");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"Массив размера {rows}*{columns}:");
    int[,] numbers = new int[rows, columns];
    FillArray52(numbers, 0, 10);
    PrintArray52(numbers);

    void Find(int[,] numbers)
    {
        Console.WriteLine("Введите индекс i элемента:");
        int findI = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите индекс j элемента:");
        int findJ = Convert.ToInt32(Console.ReadLine());
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        if (findI < 0 || findI >= rows || findJ < 0 || findJ >= columns) Console.WriteLine($"Такого числа в массиве нет!");
        else
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (numbers[findI, findJ] == numbers[i, j]) ;
                }
            }
            Console.Write($"Число {numbers[findI, findJ]} находится в массиве");
            Console.WriteLine();
        }
    }
    Find(numbers);
}
Zadacha50();

void Zadacha52()
{
    // Задача 52. Задайте двумерный массив из целых чисел. 
    // Найдите среднее арифметическое элементов в каждом столбце.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    Console.WriteLine("______________________________________");
    Console.WriteLine("Задача 52.");
    Console.WriteLine("Сколько строк будет в массиве?");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сколько столбцов будет в массиве?");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"Массив размера {rows}*{columns}:");
    int[,] numbers = new int[rows, columns];
    FillArray52(numbers, 0, 10);
    PrintArray52(numbers);
    double average = 0;
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = sum + numbers[i, j];
            average = Math.Round((sum / rows), 1);
        }
        Console.Write($"{average} \t");
    }

}

void FillArray52(int[,] numbers,
                  int minValue = 0,
                  int maxValue = 1)
{
    maxValue++;
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(minValue, maxValue);
        }
    }
}
void PrintArray52(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Zadacha52();
