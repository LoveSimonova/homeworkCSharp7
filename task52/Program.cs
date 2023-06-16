// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
int GetRows()
{
    Console.WriteLine("Введите количество строк: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetColumns()
{
    Console.WriteLine("Введите количество столбцов: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMass(int rows, int columns)
{
    int[,] massive = new int[rows,columns];
    Random rnd = new Random();
    for(int i=0;i<rows;i++)
    {
        for(int j=0;j<columns;j++)
        {
            massive[i,j]=rnd.Next(0,100);
            Console.Write($"    "+ massive[i,j]);
        }
        Console.WriteLine();
    }
    return massive;
}

void GetAverageColumn(int[,] massive)
{
    Console.Write("Средние арифметические: ");
    for (int i=0;i<massive.GetLength(1);i++)
    {
        double average=0;
        for(int j=0;j<massive.GetLength(0);j++)
            average+=massive[j,i];
        average/=massive.GetLength(0);
        Console.Write(""+average +" ");
    }
}

int m=GetRows();
int n=GetColumns();
GetAverageColumn(GetMass(m,n));
