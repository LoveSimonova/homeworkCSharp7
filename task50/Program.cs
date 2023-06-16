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

double[,] GetMass(int rows, int columns)
{
    double[,] massive = new double[rows,columns];
    Random rnd = new Random();
    for(int i=0;i<rows;i++)
    {
        for(int j=0;j<columns;j++)
        {
            massive[i,j]=rnd.NextDouble();
            Console.Write($"    "+ massive[i,j]);
        }
        Console.WriteLine();
    }
    return massive;
}

void CheckElement(double[,] massive)
{
    Console.WriteLine("Введите номер строки элемента: ");
    int numRow = Convert.ToInt32(Console.ReadLine());
    if((massive.GetLength(0)-1<numRow)||(numRow<0))
    {
        Console.WriteLine("Элемента не существует");
        return;
    }
    Console.WriteLine("Введите номер столбца элемента: ");
    int numColumn = Convert.ToInt32(Console.ReadLine());
    if((massive.GetLength(1)-1<numColumn)||(numColumn<0))
    {
        Console.WriteLine("Элемента не существует");
        return;
    }
    Console.WriteLine("Элемент: "+massive[numRow,numColumn]);
}

int m=GetRows();
int n=GetColumns();
CheckElement(GetMass(m,n));
