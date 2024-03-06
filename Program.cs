﻿using System;
internal class Program
{
    static void Main()
    {
        Array1 one = new Array1();
        Array2 two = new Array2();

        IPrinter[] printers = new IPrinter[]
        {
            one, two
        };

        foreach (IPrinter printer in printers)
        {
            Console.WriteLine($"Элементы массива {printer.GetType()}:");
            printer.Print();

            if (printer is IArray array)
            {
                Console.WriteLine($"Среднее значение {array.GetType()} массива {array.GetAverage()}");
            }
        }
    }
}