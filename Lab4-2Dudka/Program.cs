int size;
Console.WriteLine("Введите размерность квадратной матрицы:");
size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

Console.WriteLine("Введите элементы матрицы:");
for (int i = 0; i < size; i++)
{
    string[] row = Console.ReadLine().Split(' ');
    for (int j = 0; j < size; j++)
    {
        matrix[i, j] = int.Parse(row[j]);
    }
}

int[] array = new int[size * (size - 1) / 2];
int index = 0;

Console.WriteLine("Матрица:");
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write(matrix[i, j] + " ");
        if (i > j)
        {
            array[index] = matrix[i, j];
            index++;
        }
    }
    Console.WriteLine();
}

Array.Sort(array);

Console.WriteLine("Одномерный массив до сортировки:");
foreach (int element in array)
{
    Console.Write(element + " ");
}
Console.WriteLine();

Console.WriteLine("Одномерный массив после сортировки:");
Array.Reverse(array);
foreach (int element in array)
{
    Console.Write(element + " ");
}

