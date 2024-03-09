using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        string result = FilterArray(inputArray);

        Console.WriteLine("Результат: " + result);
    }

    static string FilterArray(string[] inputArray)
    {
        int count = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = "\"" + str + "\"";
                index++;
            }
        }

        return "[" + string.Join(", ", resultArray) + "]";
    }
}