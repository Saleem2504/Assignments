// See https://aka.ms/new-console-template for more information
// question 1
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Create an array of 20 elements of type integer
//         int[] array = new int[20];

//         // Initialize each of the elements with a value equals to the index of the element multiplied by 5
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = i * 5;
//         }

//         // Print the elements to the console
//         foreach (int element in array)
//         {
//             Console.WriteLine(element);
//         }
//     }
// }
// question 2
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Read two arrays from the console
//         Console.WriteLine("Enter the first array:");
//         int[] firstArray = ReadArrayFromConsole();

//         Console.WriteLine("Enter the second array:");
//         int[] secondArray = ReadArrayFromConsole();

//         // Check if the two arrays are equal
//         bool areEqual = AreArraysEqual(firstArray, secondArray);

//         // Print the result
//         if (areEqual)
//         {
//             Console.WriteLine("The two arrays are equal.");
//         }
//         else
//         {
//             Console.WriteLine("The two arrays are not equal.");
//         }
//     }

//     private static int[] ReadArrayFromConsole()
//     {
//         string[] input = Console.ReadLine().Split();
//         int[] array = new int[input.Length];
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = int.Parse(input[i]);
//         }

//         return array;
//     }

//     private static bool AreArraysEqual(int[] firstArray, int[] secondArray)
//     {
//         if (firstArray.Length != secondArray.Length)
//         {
//             return false;
//         }

//         for (int i = 0; i < firstArray.Length; i++)
//         {
//             if (firstArray[i] != secondArray[i])
//             {
//                 return false;
//             }
//         }

//         return true;
//     }
// }

// question 3
public class CompareCharArraysLexicographically
{
    public static void Main(string[] args)
    {
        char[] array1 = new char[] { 'a', 'b', 'c' };
        char[] array2 = new char[] { 'a', 'b', 'd' };

        int result = CompareLexicographically(array1, array2);

        if (result < 0)
        {
            Console.WriteLine("Array 1 is lexicographically less than Array 2.");
        }
        else if (result > 0)
        {
            Console.WriteLine("Array 1 is lexicographically greater than Array 2.");
        }
        else
        {
            Console.WriteLine("Array 1 and Array 2 are lexicographically equal.");
        }
    }

    private static int CompareLexicographically(char[] array1, char[] array2)
    {
        int length = Math.Min(array1.Length, array2.Length);
        for (int i = 0; i < length; i++)
        {
            if (array1[i] < array2[i])
            {
                return -1;
            }
            else if (array1[i] > array2[i])
            {
                return 1;
            }
        }

        // If the two arrays are the same length, then they are lexicographically equal.
        return array1.Length == array2.Length ? 0 : 1;
    }
}