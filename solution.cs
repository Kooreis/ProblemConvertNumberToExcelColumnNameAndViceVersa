Here is a full working console application in C# that solves the problem:

```C#
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

        Console.WriteLine("Enter an Excel-style column name to convert to number:");
        string columnName = Console.ReadLine();
        Console.WriteLine("Number: " + ColumnNameToNumber(columnName));
    }

    static string NumberToColumnName(int number)
    {
        var columnName = new Stack<char>();
        while (number > 0)
        {
            columnName.Push((char)('A' + --number % 26));
            number /= 26;
        }
        return new string(columnName.ToArray());
    }

    static int ColumnNameToNumber(string columnName)
    {
        int number = 0;
        for (int i = 0; i < columnName.Length; i++)
        {
            number *= 26;
            number += columnName[i] - 'A' + 1;
        }
        return number;
    }
}
```

This console application first asks the user to enter a number, which it then converts to an Excel-style column name using the `NumberToColumnName` method. It then asks the user to enter an Excel-style column name, which it converts to a number using the `ColumnNameToNumber` method.