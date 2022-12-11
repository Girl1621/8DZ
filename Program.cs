//Задача 54: Задайте двумерный массив. Напишите метод, который 
//упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.WriteLine("Введите m - ");
// bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите n - ");
// bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

// int[,] array = Create2DArray(m, n);
// Print2DArray(array);
// Console.WriteLine();

// SortElementsInDescendingOrder(array);
// PrintArray(array);


// int[,] Create2DArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     Random random = new Random();
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(10, 20);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SortElementsInDescendingOrder(int [,] array)
// {
//     for (int k = 0; k < array.GetLength(0); k++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 int max = array[k, j];
//                 if (array[k, i] > max)
//                 {
//                     int temp = array[k, i];
//                     array[k, i] = array[k, j];
//                     array[k, j] = temp;
//                 }
//             }
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }


// Задача 56: Задайте двумерный массив. Напишите метод, который будет находить строку 
// с наименьшей суммой элементов.

// Console.WriteLine("Введите m - ");
// bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите n - ");
// bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

// int[,] array = Create2DArray(m, n);
// Print2DArray(array);
// Console.WriteLine();
// int [] result = FindSumElements(array);
// PrintArray(result);
// Console.WriteLine();
// int min = FindIndex(result);
// Console.WriteLine($"{min + 1} строкa с наименьшей суммой элементов.");


// int[,] Create2DArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     Random random = new Random();
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(1, 20);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [] FindSumElements (int [,] array)
// {
//     int [] result = new int [array.GetLength(0)];
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             sum+= array[i, j];
//         }
//        result[i] = sum;
//     }
//     return result;
// }

// int FindIndex (int [] array)
// {
//     int min = array[0];
//     int index = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if(min > array[i])
//         {
//             min = array[i];
//             index = i;
//         }
//     }
//     return index;
// }

// void PrintArray (int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array [i]} ");
//     }
// }

//Задача 58: Задайте две матрицы. Напишите метод, который будет находить произведение двух матриц.

Console.WriteLine("Введите число строк 1-й матрицы: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число столбцов 1-й матрицы и строк 2-й: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
bool isParsedP = int.TryParse(Console.ReadLine(), out int p);

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
WriteArray(firstMartrix);
Console.WriteLine();
int[,] secondMartrix = new int[n, p];
CreateArray(secondMartrix);
WriteArray(secondMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц: ");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($"{array[i,j] } ");

//       else Console.Write($"{array[i,j] } ");
//     }
//     Console.WriteLine();
//   }
// }
