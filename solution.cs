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