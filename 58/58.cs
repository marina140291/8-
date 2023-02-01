// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

void InputMatrix1(int[,] matrix1)
{
    for ( int i1 = 0 ; i1 < matrix1.GetLength(0) ; i1++)
    {
    for ( int j1 = 0 ; j1 < matrix1.GetLength(1) ; j1++) 
   
    {
        matrix1[i1, j1] = new Random().Next(1,5);
        Console.Write($"{matrix1[i1, j1]}  \t");
    }   
    Console.WriteLine();
    }
    }

void InputMatrix2(int[,] matrix2)
{
    for ( int i2 = 0 ; i2 < matrix2.GetLength(0) ; i2++)
    {
    for ( int j2 = 0 ; j2 < matrix2.GetLength(1) ; j2++) 
   
    {
        matrix2[i2, j2] = new Random().Next(1,5);
        Console.Write($"{matrix2[i2, j2]}  \t");
    }   
    Console.WriteLine();
    }
    }

    void FillArray (int[,]matrix1,int[,]matrix2)

    {for ( int i2 = 0 ; i2 < matrix2.GetLength(0) ; i2++)
    {for ( int j2 = 0 ; j2 < matrix2.GetLength(1) ; j2++)
    {for ( int i1 = 0 ; i1 < matrix1.GetLength(0) ; i1++)
    {for ( int j1 = 0 ; j1 < matrix1.GetLength(1) ; j1++)
     {if (i1==i2 && j1==j2)
    
                Console.Write($"{matrix1[i1, j1]*matrix2[i2, j2]} \t");//Не получается выводить ввиде матрицы
                }
                }}}

     
     }
     

      


      
Console.Clear();
Console.Write("Введите размер матрицы 1: ");
int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix1= new int[size1[0], size1[1]];
Console.WriteLine("Начальная матрица1: ");
InputMatrix1(matrix1);

Console.WriteLine();
Console.Write("Введите размер матрицы 2: ");
int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix2= new int[size2[0], size2[1]];
Console.WriteLine("Начальная матрица2: ");
InputMatrix2(matrix2);
Console.WriteLine();


Console.WriteLine();
FillArray(matrix1,matrix2);
Console.WriteLine();