 //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void InputMatrix(int[,] matrix)
{
    for ( int i = 0 ; i < matrix.GetLength(0) ; i++)
    {
    for ( int j = 0 ; j < matrix.GetLength(1) ; j++) 
    {
        matrix[i, j] = new Random().Next(1,11);
        Console.Write($"{matrix[i, j]} \t");
    }   
    Console.WriteLine();
    }
}
void Release(int[,]matrix)
{int summin=matrix[0,0];
 for ( int i = 0 ; i < matrix.GetLength(0); i++)
    {int sum = 0;
    for ( int j = 0 ; j < matrix.GetLength(1) ; j++)
    sum+=matrix[i,j];

    Console.WriteLine($"Сумма {i+1} строки: {sum}");
    }
 
    }
    
    
     
    

    
       
      


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Release(matrix);
Console.WriteLine();