//
В данной задаче необходимо добавить обобщения в типы массивов. Типы массивов в данной задаче - одномерные и двумерные. Каждый вид массива должен иметь возможность быть созданным с поддержкой следующих типов: int, double, bool, string. У класса массива сохраняется логика заполнения пользовательскими и случайными значениями. Созданные интерфейсы для базового массива, объекта с методом печати все еще актуальны. Как и ранее созданная иерархия классов массивов.

Ожидаемое поведение метода Main(). Созданы типизированные экземпляры одномерных и двумерных массивов для каждого из указанных выше типов данных. Все созданные объекты приведены к типу IPrinter и напечатаны


using System;

sealed class Array1 : ArrayBase
{
    private Random random;
    private int[] _array;

    public Array1()
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
        Console.Write("Enter the length of the array1: ");
        string lengthInput = Console.ReadLine();

        int.TryParse(lengthInput, out int length);
        
        _array = new int[length];

        Console.WriteLine($"Введите {_array.Length} чисел:");

        for (int i = 0; i < _array.Length; i++)
        {
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int value))
            {
                _array[i] = value;
            }
            else
            {
                throw new ArgumentException("Invalid user input");
            }
        }
    }

    protected override void ArrRand()
    {
        Console.Write("Enter the length of the array1: ");
        string lengthInput = Console.ReadLine();

        int.TryParse(lengthInput, out int length);
        
        _array = new int[length];
        
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = random.Next(1, 101);
        }
    }


    public override void Print()
    {
        Console.WriteLine(string.Join(" ", _array));
    }

}