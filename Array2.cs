using System;

sealed class Array2<T> : ArrayBase<T?>
{
    private Random random;
    private IValueProvider<T> _provider;
    private T[,] array;

    public Array2() : base()
    {        

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
                array[i, j] = CreateRandomValue();
            }
        }
    }


   private T CreateRandomValue() 
    {
        if (typeof(T) == typeof(int)) 
        {
            Random random = new Random(); 

            int minValue = 1; 
            int maxValue = 100;

            return (T)(object)random.Next(minValue, maxValue);
        }
        else
        {
            throw new InvalidOperationException($"The type {typeof(T).FullName} is not supported.");
        }
    }



    public override double GetAverage()
    {
        long sum = 0;
        int count = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += Convert.ToInt64(array[i, j]);
                count++;
            }
        }

        return (double)sum / count;
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
