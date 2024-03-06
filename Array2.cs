using System;

sealed class Array2 : ArrayBase
{
    private Random random;
    private int[,] array;

    public Array2()
    {
        InitializeArray();
    }

    protected override void InitializeArray()
    {
        Console.Write("Enter 'true' for user input or 'false' for random input: ");
        string userInput = Console.ReadLine();

        bool.TryParse(userInput, out bool isUserInput);
        
        random = new Random();

        if (isUserInput)
        {
            ArrUsInp();
        }
        else
        {
            ArrRand();
        }
    }

    protected override void ArrUsInp()
    {
        Console.Write("Enter the number of rows for the array2: ");
        string rowsInput = Console.ReadLine();

        Console.Write("Enter the number of columns for the array2: ");
        string columnsInput = Console.ReadLine();

        int.TryParse(rowsInput, out int rows); 
        int.TryParse(columnsInput, out int columns);
        
        array = new int[rows, columns];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"Enter value for element [{i+1},{j+1}]: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int value))
                {
                    array[i, j] = value;
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
        Console.Write("Enter the number of rows for the array2: ");
        string rowsInput = Console.ReadLine();

        Console.Write("Enter the number of columns for the array2: ");
        string columnsInput = Console.ReadLine();

        int.TryParse(rowsInput, out int rows); 
        int.TryParse(columnsInput, out int columns);
        
        array = new int[rows, columns];
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }
    }

    public override double GetAverage()
    {
        int sum = 0;
        int count = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
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
