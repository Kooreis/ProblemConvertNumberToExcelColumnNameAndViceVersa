using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to convert to Excel-style column name:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Excel-style column name: " + NumberToColumnName(number));
    }