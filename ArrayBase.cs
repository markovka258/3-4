using System;
public abstract class ArrayBase<T> : IArray, IPrinter
{
    
    private Random random;


    protected virtual void InitializeArray()
    {
        Console.Write("Enter 'true' for user input or 'false' for random input: ");
        string userInput = Console.ReadLine();

        bool.TryParse(userInput, out bool isUserInput);
        
        if (isUserInput)
        {
            ArrUsInp();
        }
        else
        {
            ArrRand();
        }
    }

    protected abstract void ArrUsInp();

    protected abstract void ArrRand();

    public abstract void Print();
}