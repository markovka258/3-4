/*
В данной задаче необходимо добавить обобщения в типы массивов. Типы массивов в данной задаче - одномерные и двумерные. Каждый вид массива должен иметь возможность быть созданным с поддержкой следующих типов: int, double, bool, string. У класса массива сохраняется логика заполнения пользовательскими и случайными значениями. Созданные интерфейсы для базового массива, объекта с методом печати все еще актуальны. Как и ранее созданная иерархия классов массивов.
Ожидаемое поведение метода Main(). Созданы типизированные экземпляры одномерных и двумерных массивов для каждого из указанных выше типов данных. Все созданные объекты приведены к типу IPrinter и напечатаны
*/
using System;
using System.Collections.Concurrent;

sealed class Array1<T> : ArrayBase<T> 
{
    private Random random;
    private IValueProvider<T> _provider;
    private T[] array;

    public Array1(IValueProvider<T> provider) 
    {    
        _provider = provider;

        InitializeArray();
    }

    protected override void ArrUsInp()
     {
        Console.Write("Enter the length of the array1: ");
        string lengthInput = Console.ReadLine();

        int.TryParse(lengthInput, out int length);

        array = new T[length];

        Console.WriteLine($"Введите {array.Length} чисел:");

        for (int i = 0; i < array.Length; i++)
        {
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int value))
            {
                array[i] = (T)(object)value;
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
        
        array = new T[length];
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = _provider.GetRandomValue();
        }
    }

    public override void Print()
    {
        foreach (T value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }

}