Console.WriteLine("Напишите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите номер колонны: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,12);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}