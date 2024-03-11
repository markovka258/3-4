﻿using System;
internal class Program
{
    static void Main()
    {
        IValueProvider<int> intarrayprov = new  ProvValInt();
        IValueProvider<double> doubarrayprov = new  ProvValInt();
        IValueProvider<bool> boolarrayprov = new  ProvValInt();
        IValueProvider<string> strarrayprov = new  ProvValInt();

        Array1<int> intArray1= new Array1<int>(intarrayprov);
        Array1<double> doubleArray1 = new Array1<double>(doubarrayprov);
        Array1<bool> boolArray1 = new Array1<bool>(boolarrayprov);
        Array1<string> stringArray1 = new Array1<string>();

        Array2<int> intArray2 = new Array2<int>(intarrayprov);
        Array2<double> doubleArray2 = new Array2<double>(doubarrayprov);
        Array2<bool> boolArray2 = new Array2<bool>(boolarrayprov);
        Array2<string> stringArray2 = new Array2<string>(strarrayprov);

        IPrinter[] printers = new IPrinter[]
        {
            intArray1, doubleArray1, boolArray1, stringArray1, intArray2, doubleArray2, boolArray2, stringArray2
        };

        foreach (IPrinter printer in printers)
        {
            Console.WriteLine($"Элементы массива {printer.GetType()}:");
            printer.Print();
        }
    }
}