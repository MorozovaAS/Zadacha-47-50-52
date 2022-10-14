// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void Zadacha1()
{
    void PrintArray(double[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} \t");
            }
            Console.WriteLine();
        }
    }

    double GetRandomNumber(double minimum, double maximum)
    {
        return Math.Round(new Random().NextDouble() * (maximum - minimum) + minimum, 1);
    }

    void FillArray(double[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = GetRandomNumber(-10, 10)
    ;
            }
        }
    }
    double[,] matrix = new double[3, 4];
    FillArray(matrix);
    PrintArray(matrix);
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void Zadacha2()
{
    int width = ReadData("Введите ширину массива: ");
    int length = ReadData("Введите длину массива: ");
    int[,] matrix = new int[width, length];

    int ReadData(string msg)
    {
        System.Console.Write(msg);
        int number = int.Parse(System.Console.ReadLine());
        return number;
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
    }
    FillArray(matrix);
    PrintArray(matrix);
    int x = ReadData("Введите значение X: ");
    int y = ReadData("Введите значение Y: ");
    void FindingElement(int[,] matr)
    {
        if (x < width && y < length)
        {
            System.Console.WriteLine("Выбранный элемент: " + matrix[x, y]);
        }
        else
        {
            System.Console.WriteLine("Числа с таким адресом в массиве нет");
        }
    }
    FindingElement(matrix);
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Zadacha3()
{

    int width = ReadData("Введите ширину массива: ");
    int length = ReadData("Введите длину массива: ");
    int[,] matrix = new int[width, length];

    int ReadData(string msg)
    {
        System.Console.Write(msg);
        int number = int.Parse(System.Console.ReadLine());
        return number;
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
    }

    void Average(int[,] matr)
    {
        for (int j = 0; j < length; j++)
        {
            double sa = 0;
            for (int i = 0; i < width; i++)
            {
                sa = sa + matrix[i, j];
            }
            System.Console.WriteLine("Среднее арифметическое строки "+ (j+1) + " равно: " + Math.Round((sa / width),1));

        }
      
    }
    FillArray(matrix);
    PrintArray(matrix);
    Average(matrix);
}




