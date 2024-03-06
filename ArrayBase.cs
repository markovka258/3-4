using System;
public abstract class ArrayBase : IArray, IPrinter
{
    protected abstract void InitializeArray();

    protected abstract void ArrUsInp();

    protected abstract void ArrRand();

    public abstract double GetAverage();

    public abstract void Print();
}
