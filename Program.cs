﻿using System;
internal class Program
{
    static void Main()
    {
        Array1<int> intArray1= new Array1<int>();
        Array1<double> doubleArray1 = new Array1<double>();
        Array1<bool> boolArray1 = new Array1<bool>();
        Array1<string> stringArray1 = new Array1<string>();

        Array2<int> intArray2 = new Array2<int>();
        Array2<double> doubleArray2 = new Array2<double>();
        Array2<bool> boolArray2 = new Array2<bool>();
        Array2<string> stringArray2 = new Array2<string>();

        IPrinter[] printers = new IPrinter[]
        {
            intArray1, doubleArray1, boolArray1, stringArray1, intArray2, doubleArray2, boolArray2, stringArray2
        };

        foreach (IPrinter printer in printers)
        {
            Console.WriteLine($"Элементы массива {printer.GetType()}:");
            printer.Print();

            if (printer is IArray array)
            {
               if (array is Array1<int> array11)
               {
                    Console.WriteLine($"Среднее значение {array11.GetType()} массива {array11.GetAverage()}");
               }

               else if ( array is Array1<double> array12)
               {
                    Console.WriteLine($"Среднее значение {array12.GetType()} массива {array12.GetAverage()}");
               }
            }
        }
    }
}