using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        IdentityMatrix();
        SumOfArrayElements();
        MergeTwoArrays();
        CountElementFrequency();
        FindMaxAndMinElement();
        FindSecondLargestElement();
    }

    #region Identity Matrix
    static void IdentityMatrix()
    {
        Console.Write("Enter the size of the Identity Matrix (n): ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                    Console.Write("1 ");
                else
                    Console.Write("0 ");
            }
            Console.WriteLine();
        }
    }
    #endregion

    #region Sum of All Elements of an Array
    static void SumOfArrayElements()
{
    Console.Write("Enter the size of the array: ");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    int sum = 0;

    Console.WriteLine("Enter the elements of the array:");
    for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
        sum += array[i];
    }
    Console.WriteLine($"Sum of all elements: {sum}");
}
#endregion

#region Merge Two Arrays in Ascending Order
static void MergeTwoArrays()
    {
        Console.Write("Enter the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());
        int[] array1 = new int[size];
        int[] array2 = new int[size];

        Console.WriteLine("Enter elements of the first array:");
        for (int i = 0; i < size; i++)
            array1[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of the second array:");
        for (int i = 0; i < size; i++)
            array2[i] = int.Parse(Console.ReadLine());

        int[] mergedArray = array1.Concat(array2).OrderBy(x => x).ToArray();
        Console.WriteLine("Merged array in ascending order:");
        Console.WriteLine(string.Join(" ", mergedArray));
    }
    #endregion

    #region Count Frequency of Each Element in an Array
    static void CountElementFrequency()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
            array[i] = int.Parse(Console.ReadLine());

        var frequency = array.GroupBy(x => x)
                             .ToDictionary(g => g.Key, g => g.Count());

        Console.WriteLine("Frequency of each element:");
        foreach (var item in frequency)
            Console.WriteLine($"Element {item.Key} occurs {item.Value} time(s).");
    }
    #endregion

    #region Find Maximum and Minimum Elements in an Array
    static void FindMaxAndMinElement()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
            array[i] = int.Parse(Console.ReadLine());

        int max = array.Max();
        int min = array.Min();
        Console.WriteLine($"Maximum element: {max}");
        Console.WriteLine($"Minimum element: {min}");
    }
    #endregion

    #region Find the Second Largest Element in an Array
    static void FindSecondLargestElement()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
            array[i] = int.Parse(Console.ReadLine());

        int max = array.Max();
        int secondMax = array.Where(x => x != max).DefaultIfEmpty(int.MinValue).Max();

        Console.WriteLine($"Second largest element: {secondMax}");
    }
    #endregion
}

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        LongestDistanceBetweenEqualCells();
        ReverseOrderOfWords();
        CopyMultiDimensionalArray();
        ReverseOneDimensionalArray();
    }

    #region Longest Distance Between Two Equal Cells
    static void LongestDistanceBetweenEqualCells()
    {
        Console.Write("Enter array elements separated by spaces: ");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
        int longestDistance = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (!firstOccurrence.ContainsKey(array[i]))
            {
                firstOccurrence[array[i]] = i;
            }
            else
            {
                int distance = i - firstOccurrence[array[i]];
                if (distance > longestDistance)
                {
                    longestDistance = distance;
                }
            }
        }

        Console.WriteLine($"Longest distance between two equal cells: {longestDistance}");
    }
    #endregion

    #region Reverse Order of Words
    static void ReverseOrderOfWords()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string reversed = string.Join(" ", input.Split(' ')[..].Reverse());
        Console.WriteLine($"Reversed: {reversed}");
    }
    #endregion

    #region Copy Multi-dimensional Array
    static void CopyMultiDimensionalArray()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] array1 = new int[rows, cols];
        int[,] array2 = new int[rows, cols];

        Console.WriteLine("Enter elements for the first array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                array1[i, j] = int.Parse(Console.ReadLine());
                array2[i, j] = array1[i, j];
            }
        }

        Console.WriteLine("Elements of the second array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    #endregion

    #region Reverse One-dimensional Array
    static void ReverseOneDimensionalArray()
    {
        Console.Write("Enter array elements separated by spaces: ");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.WriteLine("Reversed Array:");
        Array.Reverse(array);
        Console.WriteLine(string.Join(" ", array));
    }
    #endregion
}

