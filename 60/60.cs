// See Задача 60. ...Сформируйте трёхмерный массив из 
//неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2


void InputMatrix(int[,,] matrix)
{
    for ( int i = 0 ; i < matrix.GetLength(0) ; i++)
    {
    for ( int j = 0 ; j < matrix.GetLength(1) ; j++) 
    {
        for ( int z = 0 ; z < matrix.GetLength(2) ; z++)
    {
        matrix[i, j, z] = new Random().Next(1,100);
        Console.Write($"{matrix[i, j, z]} ({i} , {j} , {z}) \t");
    }   
    Console.WriteLine();
    }
    }
}

      
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
Console.WriteLine();
