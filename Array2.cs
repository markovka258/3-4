using System;

sealed class Array2<T> : ArrayBase<T?>
{
    private Random random;
    private IValueProvider<T> _provider;
    private T[,] array;

    public Array2(IValueProvider<T> provider) : base()
    {        
        _provider = provider;
    }

    protected void InitializeArray()
    {
        
    }

    protected override void ArrUsInp()
    {
        Console.Write("Enter the number of rows for the array2: ");
        string rowsInput = Console.ReadLine();

        Console.Write("Enter the number of columns for the array2: ");
        string columnsInput = Console.ReadLine();

        int.TryParse(rowsInput, out int rows); 
        int.TryParse(columnsInput, out int columns);
        
        array = new T[rows, columns];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"Enter value for element [{i+1},{j+1}]: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int value))
                {
                    array[i, j] = (T)(object)value;
                }
                else
                {
                    throw new ArgumentException("Invalid user input");
                }
            }
        }
    }

    protected override void ArrRand()
    {
        random = new Random();
        
        Console.Write("Enter the number of rows for the array2: ");
        string rowsInput = Console.ReadLine();

        Console.Write("Enter the number of columns for the array2: ");
        string columnsInput = Console.ReadLine();

        int.TryParse(rowsInput, out int rows); 
        int.TryParse(columnsInput, out int columns);
        
        array = new T[rows, columns];
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = _provider.GetRandomValue();
            }
        }
    }



    public override void Print()
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
